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
    public partial class frmClaim : Form
    {
        int userID;
        public frmClaim(int id)
        {
            InitializeComponent();
            userID = id;
        }

        private void populateReportItemsGrid()
        {
            using (SqlConnection conn = new SqlConnection(Resources.conString))
            {
                try
                {
                    conn.Open();
                    string query = "Select ItemID,Name,Description,reportTime,DateLostFound,Status,OwnerID,FinderID,CategoryID,LocationID from Items";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sqlDataAdapter.Fill(dt);
                    dgvReportedItems.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        private void pbItemImageR_Click(object sender, EventArgs e)
        {

        }

        private void frmClaims_Load(object sender, EventArgs e)
        {
            populateReportItemsGrid();
        }

        private void dgvReportedItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvReportedItems.Rows[e.RowIndex];
                txtItemID.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtDescription.Text = row.Cells[2].Value.ToString();
                dtpLostFoundDate.Text = row.Cells[4].Value.ToString();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtItemID.Text)|| string.IsNullOrEmpty(dtpLostFoundDate.Text))
            {
                MessageBox.Show("All fields must be filled ");
                return;
            }

            int ItemID = int.Parse(txtItemID.Text);
            int uID = userID;         
            DateTime claimDate = dtpLostFoundDate.Value;
            string status = "Pending";
            try
            
            {
                using(SqlConnection conn = new SqlConnection(Resources.conString))
                {
                    conn.Open();
                    string query = "Insert into Claims (ItemID,UserID,ClaimDate,Status) Values(@ItemID,@UserID,@ClaimDate,@Status)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ItemID", ItemID);
                    cmd.Parameters.AddWithValue("@UserID", uID);
                    cmd.Parameters.AddWithValue("@ClaimDate", claimDate);
                    cmd.Parameters.AddWithValue("@Status", status);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0) { 
                        MessageBox.Show("Item Claimed Successfully ","Successfull",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Item Not inserted");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
