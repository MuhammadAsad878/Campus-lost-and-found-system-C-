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
using System.Windows.Forms;

namespace CampusLostAndFoundSystem.Forms
{
    public partial class frmReport : Form
    {
        UtilityFunctions util;
        public frmReport()
        {
           
            InitializeComponent();
            util = new UtilityFunctions();
        }

        private void pbItemImageR_Click(object sender, EventArgs e)
        {
            util.LoadImageIntoPictureBox(pbItemImageR);
        }

        private void btnAddItemImageR_Click(object sender, EventArgs e)
        {
            util.LoadImageIntoPictureBox(pbItemImageR);
        }

        private void btnDelItemImageR_Click(object sender, EventArgs e)
        {
            util.RemoveImageFromPictureBox(pbItemImageR);
        }




        private void btnReprtItem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtRepName.Text) || string.IsNullOrEmpty(txtRepDesc.Text) || string.IsNullOrEmpty(cmbRepLoca.Text) || string.IsNullOrEmpty(cmbRepCat.Text) || string.IsNullOrEmpty(cmbRepCat.Text) || string.IsNullOrEmpty(cmbRepStatus.Text) || string.IsNullOrEmpty(txtUname.Text))
            {
                MessageBox.Show("All Fields Must be Filled");
                return;
            }

            int userID = util.returnIDIfValidUser(txtUname.Text);
            if(userID == 0)
            {
                MessageBox.Show("Username Incorrect", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string repName = txtRepName.Text;
            string repDescription = txtRepDesc.Text;

            int locID = Convert.ToInt32(cmbRepLoca.SelectedValue);
            int catID = Convert.ToInt32(cmbRepCat.SelectedValue);
            DateTime date = dtpRepDate.Value;
            DateTime time = DateTime.Now;
            byte[] imageData = util.CheckPbAndConvertItsImageToByte(pbItemImageR);
            string status = cmbRepStatus.Text;
       
            try
            {
                using(SqlConnection conn = new SqlConnection(Resources.conString))
                {
                    string query = @"Insert into Items (Name,Description,ItemImage,reportTime,DateLostFound,Status,OwnerID,FinderID,CategoryID,LocationID)
                                      Values(@Name,@Description,@ItemImage,@reportTime,@DateLostFound,@Status,@OwnerID,@FinderID,@CategoryID,@LocationID)";
                    SqlCommand cmd = new SqlCommand(query,conn);
                    cmd.Parameters.AddWithValue("@Name", repName);
                    cmd.Parameters.AddWithValue("@Description", repDescription);
                    cmd.Parameters.AddWithValue("@ItemImage", imageData); 
                    cmd.Parameters.AddWithValue("@reportTime", time);
                    cmd.Parameters.AddWithValue("@DateLostFound", date);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@OwnerID", userID);
                    cmd.Parameters.AddWithValue("@FinderID", userID);
                    cmd.Parameters.AddWithValue("@CategoryID", catID);
                    cmd.Parameters.AddWithValue("@LocationID", locID);
                    conn.Open();
                    int rowsEffected = cmd.ExecuteNonQuery();
                    if(rowsEffected > 0)
                    {
                        MessageBox.Show("Your Report Submitted Successfully ", "Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                    }
                    
                    conn.Close();
                    return;


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error "+ex.Message+" ");
                return;
            }


          
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            populateComboboxes();
            cmbRepStatus.Items.Add("Lost");
            cmbRepStatus.Items.Add("Found");
        }
       
        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void populateComboboxes()
        {
            try
            {
                string query = "Select CategoryID,Name From  Categories";

                using (SqlConnection connection = new SqlConnection(Resources.conString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {

                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        cmbRepCat.DataSource = dataTable;
                        cmbRepCat.DisplayMember = "Name";
                        cmbRepCat.ValueMember = "CategoryID";
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                string query = "Select LocationID,Name From  Locations";

                using (SqlConnection connection = new SqlConnection(Resources.conString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {

                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        cmbRepLoca.DataSource = dataTable;
                        cmbRepLoca.DisplayMember = "Name";
                        cmbRepLoca.ValueMember = "LocationID";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
    }
}
