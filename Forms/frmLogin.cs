using CampusLostAndFoundSystem.Properties;
using CampusLostAndFoundSystem.UtilityClasses;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CampusLostAndFoundSystem.Forms
{
    public partial class frmLogin : Form
    {
        UtilityFunctions util;
        public frmLogin()
        {
            util = new UtilityFunctions();
            InitializeComponent();
        }

        

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            if (txtUNameAdmin.Text == "admin" && txtPwdAdmin.Text == "admin")
            {
                this.Hide();
              
            }
        }

        private void chBPwdUser_CheckedChanged(object sender, EventArgs e)
        {
                
        }

        private void chBPwdAdmin_CheckedChanged(object sender, EventArgs e)
        {
            
          
        }

        private void lblLogUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabAdminLogin.Hide();
            tabLogin.Show();
        }

        private void lblLogAdmin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabLogin.Hide();
            tabAdminLogin.Show();
        }

        private void lblUSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabLogin.Hide();
            tabSignup.Show();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            tabSignup.Hide();
            tabLogin.Show();
        }

        private void btnLoginUser_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUNameUser.Text) || string.IsNullOrEmpty(txtPwdUser.Text))
            {
                MessageBox.Show("Please enter username and password");
                return;
            }
            string userName = txtUNameUser.Text;
            string pwd = txtPwdUser.Text;         
            
               if (util.isValidUser(userName, pwd))
                {
               
                int id = util.returnIDIfValidUser(userName);
                if(id != 0)
                {
                    frmMain mainAdmin = new frmMain(false, userName, id);
                    mainAdmin.Show();
                    this.Hide();
                   
                }
                MessageBox.Show("Login successful!");

            }          
            else
            {
                DialogResult result = MessageBox.Show("Invalid Credentials \n Are you registered ", "Error!", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Try Again", "Try Again", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    DialogResult res = MessageBox.Show("You want to register first !", "REGISTRATION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (res == DialogResult.Yes)
                    {
                        tabLogin.Hide();
                        tabSignup.Show();
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        private void lblLogAdmin_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

            tabLogin.Hide();
            tabAdminLogin.Show();
        }

        private void btnSignup_Click_1(object sender, EventArgs e)
        {
            
            if(string.IsNullOrEmpty(txtAddressSignup.Text) || string.IsNullOrEmpty(txtPhoneSignup.Text) || string.IsNullOrEmpty(txtEmailSignup.Text)|| string.IsNullOrEmpty(txtConfPwdSignup.Text) || string.IsNullOrEmpty(txtUNameSignup.Text) )
            {
                MessageBox.Show("All Fields Must be filled !", "All Fields Must be filled !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }else if( txtConfPwdSignup.Text.Trim() != txtPwdSignup.Text.Trim())
            {
                MessageBox.Show("Both Password and Confirm Password Must be same !");
                return;
            }
            // Email  Validation
            if (util.IsEmailAlreadyExistInTextBox(txtEmailSignup))
            {
                MessageBox.Show("Email Already Existed !", "Use Another Email !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
         
            string Username = txtUNameSignup.Text;
            string Password = txtPwdSignup.Text.Trim();
            string Address = txtAddressSignup.Text;
            string Email = txtEmailSignup.Text.Trim();
            string Phone = txtPhoneSignup.Text.Trim();
            string Role = "Teacher";
          
            if(rdbE.Checked) { Role = "Employee"; }else if(rdbS.Checked) { Role = "Student"; }else if(rdbV.Checked) { Role = "Visitor"; }


            try
            {
                using (SqlConnection conn = new SqlConnection(Resources.conString))
                {
                    string query = @"INSERT INTO Users (ProfileImage, Username, Phone, Email, Password, Role, Address) 
                                    VALUES (@ProfileImage, @Username, @Phone, @Email, @Password, @Role, @Address)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    byte[] profileImageBytes = util.CheckPbAndConvertItsImageToByte(pbProfileSignup);

                    if (profileImageBytes != null) {
                        cmd.Parameters.AddWithValue("@ProfileImage", profileImageBytes); 
                    }
                    else {
                        cmd.Parameters.AddWithValue("@ProfileImage", DBNull.Value); 
                    }

                    cmd.Parameters.AddWithValue("@Username", Username);
                    cmd.Parameters.AddWithValue("@Phone", Phone);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.Parameters.AddWithValue("@Role", Role);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    conn.Open();
                    int rowsEffected = cmd.ExecuteNonQuery();
                    if (rowsEffected > 0)
                    {
                        MessageBox.Show("Data Inserted");
                        cmd.CommandText = "SELECT UserID,ProfileImage,Username FROM Users WHERE Email = @Email";

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                              int  id = reader.GetInt32(0);
                                                        

                                if (id != 0)
                                {
                                    MessageBox.Show($"Congratulations! {Username} \nYou have successfully signed up \nYour ID is {id}");
                                    frmMain main = new frmMain(false, Username,id);
                                    main.Show();
                                    this.Hide();
                                }
                            }
                            else
                            {
                                MessageBox.Show("User ID not found.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void btnAddProfileImage_Click(object sender, EventArgs e)
        {
         util.LoadImageIntoPictureBox(pbProfileSignup);
        }



        private void btnDelProfileImage_Click(object sender, EventArgs e)
        {
          util.RemoveImageFromPictureBox(pbProfileSignup);
        }

        private void pbProfileSignup_Click(object sender, EventArgs e)
        {
          util.LoadImageIntoPictureBox(pbProfileSignup);
        }

        private void lblUSignup_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabLogin.Hide();
            tabSignup.Show();
        }

        private void chBPwdUser_CheckedChanged_1(object sender, EventArgs e)
        {
            util.ShowHidePasswordForUsing(txtPwdUser, chBPwdUser);
        }

        private void chBSignup_CheckedChanged(object sender, EventArgs e)
        {
            util.ShowHidePasswordForUsing(txtPwdSignup, txtConfPwdSignup, chBSignup);
        }

        private void chBPwdAdmin_CheckedChanged_1(object sender, EventArgs e)
        {
            util.ShowHidePasswordForUsing(txtPwdAdmin,chBPwdAdmin);
        }

        private void lblLogUser_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {

            tabAdminLogin.Hide();
            tabLogin.Show();
        }

        private void txtUNameUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLoginAdmin_Click_1(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtUNameAdmin.Text) || string.IsNullOrEmpty(txtPwdAdmin.Text))
            {
                MessageBox.Show("Please enter username and password");
                return;
            }
            string userName = txtUNameAdmin.Text;
            string pwd = txtPwdAdmin.Text;       
            string name = userName;
            if (util.isValidAdmin(userName, pwd))
            {
                MessageBox.Show("Login successful!");

                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                 this.Hide();

            }
            else
            {
                MessageBox.Show("Enter Valid Credentials !","Error ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void label13_Click(object sender, EventArgs e)
        {
            tabSignup.Hide();
            tabLogin.Show();
        }

        private void txtUNameAdmin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
