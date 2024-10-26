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
    public partial class frmManageClaims : Form
    {
        public frmManageClaims()
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
                    string query = "Select * from Claims where Status = @Status";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Status", "Pending");
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sqlDataAdapter.Fill(dt);
                    dgvClaimItems.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvClaimItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string status = "Pending";
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvClaimItems.Rows[e.RowIndex];
                txtClaimID.Text = row.Cells["ClaimID"].Value.ToString();
                status = row.Cells["Status"].Value.ToString();
                if(status == "Pending")
                {
                    rdbP.Checked = true;
                }
                else
                {
                    rdbA.Checked = true;
                }

            }
        }

        private void btnUpdateClaim_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtClaimID.Text))
            {
                MessageBox.Show("Please enter claim ID");
                return;
            }
            int claimID = int.Parse(txtClaimID.Text);
            string status = "Pending";
            if(rdbA.Checked)
            {
                status = "Approved";
            }
          
            try
            {
                using(SqlConnection conn = new SqlConnection(Resources.conString))
                {
                    conn.Open();
                    string query = "Update Claims set Status = @Status where ClaimID=@ClaimID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@ClaimID",claimID);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Claim Updated Succesfully");
                        populateDataGrid();

                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
