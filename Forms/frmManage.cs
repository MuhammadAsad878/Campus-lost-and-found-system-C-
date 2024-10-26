using CampusLostAndFoundSystem.Properties;
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
    public partial class frmManage : Form
    {
        public frmManage()
        {
            InitializeComponent();
            populateComboboxes();
        }

        private void populateComboboxes()
        {
            try
            {
                string query = "Select CategoryID From  Categories";

                using (SqlConnection connection = new SqlConnection(Resources.conString))
                {
                   SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    cmbCatID.Items.Clear();
                    while (reader.Read())
                    {
                        cmbCatID.Items.Add(reader.GetInt32(0).ToString());
                    }
                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            try
            {
                string query = "Select LocationID From  Locations";

                using (SqlConnection connection = new SqlConnection(Resources.conString))
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    cmbLocationID.Items.Clear();
                    while (reader.Read())
                    {
                        cmbLocationID.Items.Add(reader.GetInt32(0).ToString());
                    }
                    reader.Close();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void btnCatNew_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCatNew_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                MessageBox.Show("Please enter category first !");
                return;
            }

            string category = txtCategoryName.Text;
            try {
                using(SqlConnection conn = new SqlConnection(Resources.conString))
                {
                    string query = "Insert into Categories (Name) VALUES(@CategoryName)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open() ;
                    cmd.Parameters.AddWithValue("@CategoryName", category);
                    int result = cmd.ExecuteNonQuery();
                    if(result > 0)
                    {
                        lblMessage.ForeColor = Color.Black;
                        lblMessage.Text = "Category Inserted Successfuly ";
                        populateComboboxes();

                    }
                    else
                    {
                        lblMessage.ForeColor = Color.Red;
                        lblMessage.Text = "Error, Not inserted";
                    }
                    conn.Close();
                }
            }catch(Exception ex)
            { 
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCatDel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbCatID.Text))
            {
                MessageBox.Show("Please Select ID first !");
                return;
            }

            int categoryID =Convert.ToInt32(cmbCatID.Text);
            try
            {
                using (SqlConnection conn = new SqlConnection(Resources.conString))
                {
                    string query = "Delete From Categories Where CategoryID=@CategoryID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CategoryID", categoryID);
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        lblMessage.ForeColor = Color.Black;

                        lblMessage.Text = "Category Deleted Successfuly ";
                        populateComboboxes();
                    }
                    else
                    {
                        lblMessage.ForeColor = Color.Red;
                        lblMessage.Text = "Error, Not Deleted";
                    }
                    conn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNewLoc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCategoryName.Text))
            {
                MessageBox.Show("Please enter Location first !");
                return;
            }

            string location = txtCategoryName.Text;
            try
            {
                using (SqlConnection conn = new SqlConnection(Resources.conString))
                {
                    string query = "Insert into Locations (Name) VALUES(@Name)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    conn.Open();
                    cmd.Parameters.AddWithValue("@Name", location);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        lblMessage.ForeColor = Color.Black;
                        lblMessage.Text = "Location Inserted Successfully ";
                        populateComboboxes();
                    }
                    else
                    {
                        lblMessage.ForeColor = Color.Red;
                        lblMessage.Text = "Error, Not inserted";
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelLoc_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbLocationID.Text))
            {
                MessageBox.Show("Please Select ID first !");
                return;
            }
            int ID = int.Parse(cmbLocationID.Text);
            try
            {
                using (SqlConnection conn = new SqlConnection(Resources.conString))
                {
                    string query = "Delete From Locations Where LocationID=@ID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ID", ID);
                    conn.Open();
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        lblMessage.ForeColor = Color.Black;

                        lblMessage.Text = "Location Deleted Successfully ";
                        populateComboboxes();

                    }
                    else
                    {
                        lblMessage.ForeColor = Color.Red;
                        lblMessage.Text = "Error, Not Deleted";
                    }
                    conn.Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmCatLoc_Load(object sender, EventArgs e)
        {
           

        }

        private void cmbLocationID_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbLocationID_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbLocationID.Text))
            {
                lblMessage.Text = "ID Empty";
                return;
            }
            int id = int.Parse(cmbLocationID.Text);
            try
            {
                using (SqlConnection conn = new SqlConnection(Resources.conString))
                {
                    string query = "Select Name from Locations where LocationID=@LocationID ";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@LocationID", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        txtLocationName.Text = reader.GetString(0).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbCatID_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = int.Parse(cmbCatID.Text);
            try { 
                using(SqlConnection conn = new SqlConnection(Resources.conString))
                {
                    string query = "Select Name from Categories where CategoryID=@CategoryID ";
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@CategoryID", id);
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        txtCategoryName.Text = reader.GetString(0).ToString();
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
