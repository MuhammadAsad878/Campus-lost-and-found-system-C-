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
    public partial class AdminAccessForm : Form
    {
        public AdminAccessForm()
        {
            InitializeComponent();
            populateDataGrid();
        }
        private void populateDataGrid()
        {
            using (SqlConnection conn = new SqlConnection(Resources.conString))
            {
                try
                {
                    conn.Open();
                    string query = "Select Username,Password from Admin";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sqlDataAdapter.Fill(dt);
                    dgvAdmin.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvAdmin_CellClick(object sender, DataGridViewCellEventArgs e)
        {

           
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvAdmin.Rows[e.RowIndex];
              txtUsername.Text = row.Cells[0].Value.ToString();              
                txtPwd.Text = row.Cells[1].Value.ToString();

            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text)|| string.IsNullOrEmpty(txtPwd.Text))
            {
                MessageBox.Show("Please enter claim ID");
                return;
            }
            using (SqlConnection conn = new SqlConnection(Resources.conString))
            {
                try
                {
                    conn.Open();
                    string query = "Insert into Admin (Username,Password) Values(@Username,@Password)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPwd.Text);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("New Admin Inserted");
                    }
                    populateDataGrid();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPwd.Text))
            {
                MessageBox.Show("Please enter claim ID");
                return;
            }
            using (SqlConnection conn = new SqlConnection(Resources.conString))
            {
                try
                {
                    conn.Open();
                    string query = "Update  Admin Set Username=@Username,Password=@Password Where Username = @Username";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@Password", txtPwd.Text);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show(" Admin Updated");
                    }
                    populateDataGrid();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPwd.Text))
            {
                MessageBox.Show("Please enter claim ID");
                return;
            }
            using (SqlConnection conn = new SqlConnection(Resources.conString))
            {
                try
                {
                    conn.Open();
                    string query = "Delete  Admin  Where Username = @Username";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Username", txtUsername.Text);
                    cmd.ExecuteNonQuery();
                    populateDataGrid();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
