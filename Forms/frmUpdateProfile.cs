using CampusLostAndFoundSystem.Properties;
using CampusLostAndFoundSystem.UtilityClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;

namespace CampusLostAndFoundSystem.Forms
{
    public partial class frmUpdateProfile : Form
    {
        UtilityFunctions util;
        int userID;
        public frmUpdateProfile(int uID)
        {
            InitializeComponent();
            util = new UtilityFunctions();
            userID = uID;
            populateForm(uID);
        }

        private void btnAddProfileImage_Click(object sender, EventArgs e)
        {

            util.LoadImageIntoPictureBox(pbUpdateProfile);
        }

        private void pbUpdateProfile_Click(object sender, EventArgs e)
        {
            util.LoadImageIntoPictureBox(pbUpdateProfile);
        }

        private void btnRemUpdImage_Click(object sender, EventArgs e)
        {

            util.RemoveImageFromPictureBox(pbUpdateProfile);
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAddressUpd.Text) || string.IsNullOrEmpty(txtPhoneUpd.Text) || string.IsNullOrEmpty(txtPwdUpd.Text) || string.IsNullOrEmpty(txtUNameUpd.Text))
            {
                MessageBox.Show("All Fields Must be filled !", "All Fields Must be filled !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
           
            string Username = txtUNameUpd.Text;
            string Password = txtPwdUpd.Text.Trim();
            string Address = txtAddressUpd.Text;
            string Phone = txtPhoneUpd.Text.Trim();
            string Role = "Teacher";

            if (rdbE.Checked) { Role = "Employee"; } else if (rdbS.Checked) { Role = "Student"; } else if (rdbV.Checked) { Role = "Visitor"; }


            try
            {

                using (SqlConnection conn = new SqlConnection(Resources.conString))
                {
                    string query = @"UPDATE Users SET ProfileImage =@ProfileImage, Username =@Username, Phone= @Phone, Password= @Password, Role =@Role, Address=@Address  WHERE UserID = @UserID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    byte[] profileImageBytes = util.CheckPbAndConvertItsImageToByte(pbUpdateProfile);

                    if (profileImageBytes != null)
                    {
                        cmd.Parameters.AddWithValue("@ProfileImage", profileImageBytes);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@ProfileImage", DBNull.Value);
                    }
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    cmd.Parameters.AddWithValue("@Username", Username);
                    cmd.Parameters.AddWithValue("@Phone", Phone);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.Parameters.AddWithValue("@Role", Role);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    conn.Open();
                    int rowsEffected = cmd.ExecuteNonQuery();
                    if (rowsEffected > 0)
                    {
                        MessageBox.Show("Profile Updated Successfully !");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void populateForm(int userID)
        {
            try
            {
                string query = "Select ProfileImage, Username, Phone, Email, Password, Role, Address From Users where UserID=@UserID";
                using (SqlConnection conn = new SqlConnection(Resources.conString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@UserID", userID);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    string role = "Teacher";
                    while (reader.Read())
                    {


                        pbUpdateProfile.Image = util.convertBinaryToImage(reader, 0);

                        txtUNameUpd.Text = reader.GetString(1);
                        txtPhoneUpd.Text = reader.GetString(2);
                        txtEmailUpd.Text = reader.GetString(3);
                        txtPwdUpd.Text = reader.GetString(4);
                        role = reader.GetString(5);
                        txtAddressUpd.Text = reader.GetString(6);
                    }
                    reader.Close();

                    if (role == "Employee")
                    {
                        rdbE.Checked = true;
                    }
                    else if (role == "Student")
                    {
                        rdbS.Checked = true;
                    }
                    else if (role == "Visitor")
                    {
                        rdbV.Checked = true;
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void frmUpdateProfile_Load(object sender, EventArgs e)
        {
            populateForm(userID);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
            this.Dispose();
        }

        private void chBPwd_CheckedChanged(object sender, EventArgs e)
        {
            util.ShowHidePasswordForUsing(txtPwdUpd, chBPwd);
        }
    }
}
