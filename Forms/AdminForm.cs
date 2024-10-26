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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            replacePanelWith(new defalutForm());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            replacePanelWith(new AdminAccessForm());
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

        private void btnManageCat_Click(object sender, EventArgs e)
        {
            frmManage manage = new frmManage();
            replacePanelWith(manage);
        }

        private void btnManageClaims_Click(object sender, EventArgs e)
        {
            frmManageClaims claims = new frmManageClaims();
            replacePanelWith(claims);
        }
    }
}
