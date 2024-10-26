using CampusLostAndFoundSystem.Properties;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CampusLostAndFoundSystem.UtilityClasses
{
    public class UtilityFunctions
    {
       
        public void RemoveImageFromPictureBox(PictureBox pictureBox)
        {
            if (pictureBox.Image != null)
            {
                pictureBox.Image = null;
            }
            else
            {
                MessageBox.Show("No image to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public Image convertBinaryToImage(SqlDataReader reader,int Ordinal)
        {

            long numBytes = reader.GetBytes(Ordinal, 0, null, 0, 0);
            if (numBytes == 0) { return null; }
            byte[] imageData = new byte[numBytes];
           
            reader.GetBytes(Ordinal, 0, imageData, 0, (int)numBytes);
            MemoryStream ms = new MemoryStream(imageData);
            ms.Position = 0;
           return Image.FromStream(ms);
        }

        public bool isValidAdmin(string usernameAdmin, string passwordAdmin)
        {
          
            try
            {
                using (SqlConnection conn = new SqlConnection(Resources.conString))
                {
                    string Username = usernameAdmin;
                    string Password = passwordAdmin;
                    string query = "SELECT Username,Password FROM Admin WHERE Username=@Username AND Password =@Password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Username", Username);
                    cmd.Parameters.AddWithValue("@Password", Password);
                  
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader.GetString(0) == Username && reader.GetString(1) == Password)
                        {
                            conn.Close();
                            reader.Close();
                           
                            return true;

                        }
                        else
                        {
                            conn.Close();
                            reader.Close();
                           
                            return false;
                        }
                    }                 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);               
            }
            return false;

        }
        public bool isValidUser(string username, string password)
        {
           
            try
            {
                using (SqlConnection conn = new SqlConnection(Resources.conString))
                {   
                    string Username = username;
                    string Password = password;                              
                    string query = "SELECT Username,Password FROM Users WHERE Username=@Username AND Password =@Password";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Username", Username); 
                    cmd.Parameters.AddWithValue("@Password", Password);

                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        if (reader.GetString(0) == Username && reader.GetString(1) == Password)
                        {
                            conn.Close();
                            reader.Close();
                       
                            return true;

                        }
                        else
                        {
                            conn.Close();
                            reader.Close();
                          
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return false;

        }
        public int returnIDIfValidUser(string username)
        {
            int value = 0;

            try
            {
                using (SqlConnection conn = new SqlConnection(Resources.conString))
                {
                    string query = "SELECT UserID FROM Users WHERE Username=@Username ";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", username);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {                                                                       
                           value = reader.GetInt32(0);                      
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+"function");
            }
            return value;

        }
        public bool IsEmailAlreadyExistInTextBox(Guna2TextBox emailText)
        {
            using (SqlConnection conn = new SqlConnection(Resources.conString))
            {
                try {
                    string query = "Select Email From Users";
                    string email = emailText.Text.Trim();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                         
                        if (email == reader.GetString(0))
                        {

                            return true;
                        }
                    }
                    return false;
                }
                catch (Exception ex) { MessageBox.Show(ex.Message);
                    return false;
                }
               
            }
        }
        public void LoadImageIntoPictureBox(PictureBox pictureBox)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp";
                openFileDialog.Title = "Select an Image File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Image selectedImage = Image.FromFile(openFileDialog.FileName);
                        pictureBox.Image = selectedImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No picture was selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        public Byte[] CheckPbAndConvertItsImageToByte(PictureBox pictureBox)
        {
            if (pictureBox.Image != null)
            {
                Image image = pictureBox.Image;

                // Insert Image > MemoryStream > byte[] imageData Array 
                MemoryStream ms = new MemoryStream();
                image.Save(ms, image.RawFormat);
                byte[] imageData = ms.ToArray();
                return imageData;
            }
            else
            {
                byte[] nullImageBytes = new byte[0];
                return nullImageBytes;

            }
        }

        public void ShowHidePasswordForUsing(Guna2TextBox textBox, CheckBox checkBox)
        {
            if (checkBox.Checked)
            {
                textBox.PasswordChar = '\0';
            }
            else
            {
                textBox.PasswordChar = '*';
            }
        }
        public void ShowHidePasswordForUsing(Guna2TextBox textBo1,Guna2TextBox textBox2, CheckBox checkBox)
        {
            if (checkBox.Checked)
            {
                textBo1.PasswordChar = '\0';
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBo1.PasswordChar = '*';
                textBox2.PasswordChar = '*';
            }
        }

        public void getImageFromItemsWithID(int id)
        {
            string query = "SElect ItemImage from Items where ItemID = @ItemID";
            try
            {

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
