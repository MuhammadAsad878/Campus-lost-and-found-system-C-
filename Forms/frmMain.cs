using CampusLostAndFoundSystem.Properties;
using CampusLostAndFoundSystem.UtilityClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampusLostAndFoundSystem.Forms
{
    public partial class frmMain : Form
    {
      
        UtilityFunctions util;
        int userID;
        public frmMain(bool giveAdminAccess,string uName, int uID)
        {
            InitializeComponent();
            util = new UtilityFunctions();
            txtUNameMain.Text = uName;
            userID = uID;
            lblID.Text = uID.ToString();
            replacePanelWith(new defalutForm());
            
        }
       




        
       
        private void replacePanelWith(Form form)
        {           
            pnlParent.Controls.Clear();
            foreach (Control control in pnlParent.Controls)
            {
                if (control is Form)
                {                   
                    (control).Dispose();                   

                }
            }
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            pnlParent.Controls.Add(form);
            form.Show();

        }

       
        private void showSubMenu(Panel panelName)
        {
            if (!panelName.Visible)
            {
                panelName.Visible = true;
            }
            else
            {
                panelName.Visible = false;
            }
           
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
           
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
             replacePanelWith(new frmReport());
        }

        private void btnClaim_Click(object sender, EventArgs e)
        {
            replacePanelWith(new frmClaim(userID));
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
          
        }

        private void btnMyProfile_Click(object sender, EventArgs e)
        {
        }

        private void btnReport_Click_1(object sender, EventArgs e)
        {
            showSubMenu(subPnlReport);
        }

        private void btnAdmin_Click_1(object sender, EventArgs e)
        {
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdProfile_Click(object sender, EventArgs e)
        {
            frmUpdateProfile profile = new frmUpdateProfile(userID);
            profile.ShowDialog();
        }

        private void btnNewReport_Click(object sender, EventArgs e)
        {
          frmReport report = new frmReport();
           report.ShowDialog();
        }

        private void btnManageCat_Click(object sender, EventArgs e)
        {
            replacePanelWith(new frmManage());
        }

        private void btnMyClaims_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void btnMyClaims_Click_1(object sender, EventArgs e)
        {
            replacePanelWith(new frmClaim(userID));
        }

        private void btnMyProfile_Click_1(object sender, EventArgs e)
        {
            frmUpdateProfile updateProfile = new frmUpdateProfile(userID);
            updateProfile.ShowDialog();

        }

        private void btnAccess_Click(object sender, EventArgs e)
        {

        }

        private void pnlParent_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
          




        }
    }
}
