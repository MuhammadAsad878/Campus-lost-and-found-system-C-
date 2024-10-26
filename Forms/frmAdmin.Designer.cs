namespace CampusLostAndFoundSystem.Forms
{
    partial class frmAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdmin));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControlLogin = new MaterialSkin.Controls.MaterialTabControl();
            this.tabAdmin = new System.Windows.Forms.TabPage();
            this.btnAdminManage = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageEmails = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox3 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnManageClaims = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageUsers = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageCat = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.guna2Button20 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button12 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button13 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button14 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button15 = new Guna.UI2.WinForms.Guna2Button();
            this.dGVUserManage = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2HtmlLabel12 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.tabEmailNotifications = new System.Windows.Forms.TabPage();
            this.btnAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button16 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button17 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button18 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button19 = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControlLogin.SuspendLayout();
            this.tabAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVUserManage)).BeginInit();
            this.tabEmailNotifications.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlLogin
            // 
            this.tabControlLogin.Controls.Add(this.tabAdmin);
            this.tabControlLogin.Controls.Add(this.tabUsers);
            this.tabControlLogin.Controls.Add(this.tabEmailNotifications);
            this.tabControlLogin.Depth = 0;
            this.tabControlLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlLogin.Location = new System.Drawing.Point(0, 0);
            this.tabControlLogin.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabControlLogin.Multiline = true;
            this.tabControlLogin.Name = "tabControlLogin";
            this.tabControlLogin.SelectedIndex = 0;
            this.tabControlLogin.Size = new System.Drawing.Size(1150, 660);
            this.tabControlLogin.TabIndex = 217;
            // 
            // tabAdmin
            // 
            this.tabAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.tabAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabAdmin.Controls.Add(this.btnAdminManage);
            this.tabAdmin.Controls.Add(this.btnManageEmails);
            this.tabAdmin.Controls.Add(this.guna2CirclePictureBox3);
            this.tabAdmin.Controls.Add(this.btnManageClaims);
            this.tabAdmin.Controls.Add(this.btnManageUsers);
            this.tabAdmin.Controls.Add(this.btnManageCat);
            this.tabAdmin.Controls.Add(this.guna2Panel1);
            this.tabAdmin.Location = new System.Drawing.Point(4, 22);
            this.tabAdmin.Name = "tabAdmin";
            this.tabAdmin.Padding = new System.Windows.Forms.Padding(3);
            this.tabAdmin.Size = new System.Drawing.Size(1142, 634);
            this.tabAdmin.TabIndex = 3;
            this.tabAdmin.Text = "Admin Panel";
            // 
            // btnAdminManage
            // 
            this.btnAdminManage.BackColor = System.Drawing.Color.Transparent;
            this.btnAdminManage.BorderRadius = 10;
            this.btnAdminManage.BorderThickness = 2;
            this.btnAdminManage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminManage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdminManage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdminManage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdminManage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdminManage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.btnAdminManage.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminManage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnAdminManage.Location = new System.Drawing.Point(594, 490);
            this.btnAdminManage.Name = "btnAdminManage";
            this.btnAdminManage.Size = new System.Drawing.Size(310, 76);
            this.btnAdminManage.TabIndex = 210;
            this.btnAdminManage.Text = "Admin\'s Management";
            // 
            // btnManageEmails
            // 
            this.btnManageEmails.BackColor = System.Drawing.Color.Transparent;
            this.btnManageEmails.BorderRadius = 10;
            this.btnManageEmails.BorderThickness = 2;
            this.btnManageEmails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageEmails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageEmails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageEmails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageEmails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageEmails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.btnManageEmails.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageEmails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnManageEmails.Location = new System.Drawing.Point(594, 408);
            this.btnManageEmails.Name = "btnManageEmails";
            this.btnManageEmails.Size = new System.Drawing.Size(310, 76);
            this.btnManageEmails.TabIndex = 209;
            this.btnManageEmails.Text = "Email & Notifications";
            this.btnManageEmails.TextFormatNoPrefix = true;
            // 
            // guna2CirclePictureBox3
            // 
            this.guna2CirclePictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2CirclePictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox3.Image")));
            this.guna2CirclePictureBox3.ImageRotate = 0F;
            this.guna2CirclePictureBox3.Location = new System.Drawing.Point(2, 69);
            this.guna2CirclePictureBox3.Name = "guna2CirclePictureBox3";
            this.guna2CirclePictureBox3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox3.Size = new System.Drawing.Size(539, 482);
            this.guna2CirclePictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox3.TabIndex = 24;
            this.guna2CirclePictureBox3.TabStop = false;
            this.guna2CirclePictureBox3.UseTransparentBackground = true;
            // 
            // btnManageClaims
            // 
            this.btnManageClaims.BackColor = System.Drawing.Color.Transparent;
            this.btnManageClaims.BorderRadius = 10;
            this.btnManageClaims.BorderThickness = 2;
            this.btnManageClaims.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageClaims.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageClaims.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageClaims.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageClaims.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageClaims.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.btnManageClaims.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageClaims.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnManageClaims.Location = new System.Drawing.Point(594, 326);
            this.btnManageClaims.Name = "btnManageClaims";
            this.btnManageClaims.Size = new System.Drawing.Size(310, 76);
            this.btnManageClaims.TabIndex = 3;
            this.btnManageClaims.Text = "Manage Claims";
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.Color.Transparent;
            this.btnManageUsers.BorderRadius = 10;
            this.btnManageUsers.BorderThickness = 2;
            this.btnManageUsers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageUsers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.btnManageUsers.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnManageUsers.Location = new System.Drawing.Point(594, 241);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(310, 76);
            this.btnManageUsers.TabIndex = 2;
            this.btnManageUsers.Text = "Manage Users";
            // 
            // btnManageCat
            // 
            this.btnManageCat.BackColor = System.Drawing.Color.Transparent;
            this.btnManageCat.BorderRadius = 10;
            this.btnManageCat.BorderThickness = 2;
            this.btnManageCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageCat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageCat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageCat.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.btnManageCat.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnManageCat.Location = new System.Drawing.Point(594, 159);
            this.btnManageCat.Name = "btnManageCat";
            this.btnManageCat.Size = new System.Drawing.Size(310, 76);
            this.btnManageCat.TabIndex = 0;
            this.btnManageCat.Text = "Manage Categories/Locations";
            this.btnManageCat.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Location = new System.Drawing.Point(-1, 26);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(681, 83);
            this.guna2Panel1.TabIndex = 208;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Montserrat", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(338, 16);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(241, 50);
            this.guna2HtmlLabel2.TabIndex = 207;
            this.guna2HtmlLabel2.Text = "Admin Panel";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.guna2Panel2.BorderColor = System.Drawing.Color.White;
            this.guna2Panel2.BorderThickness = 2;
            this.guna2Panel2.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel2.Location = new System.Drawing.Point(3, 77);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(691, 10);
            this.guna2Panel2.TabIndex = 209;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Montserrat", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(381, 17);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(241, 50);
            this.guna2HtmlLabel1.TabIndex = 207;
            this.guna2HtmlLabel1.Text = "Admin Panel";
            // 
            // tabUsers
            // 
            this.tabUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.tabUsers.Controls.Add(this.guna2Button20);
            this.tabUsers.Controls.Add(this.guna2Button12);
            this.tabUsers.Controls.Add(this.guna2Button13);
            this.tabUsers.Controls.Add(this.guna2Button14);
            this.tabUsers.Controls.Add(this.guna2Button15);
            this.tabUsers.Controls.Add(this.dGVUserManage);
            this.tabUsers.Controls.Add(this.guna2HtmlLabel12);
            this.tabUsers.Location = new System.Drawing.Point(4, 22);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsers.Size = new System.Drawing.Size(1142, 634);
            this.tabUsers.TabIndex = 4;
            this.tabUsers.Text = "Users";
            // 
            // guna2Button20
            // 
            this.guna2Button20.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button20.BorderRadius = 1;
            this.guna2Button20.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Button20.BorderThickness = 1;
            this.guna2Button20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button20.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button20.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button20.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button20.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button20.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.guna2Button20.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.guna2Button20.Location = new System.Drawing.Point(667, 6);
            this.guna2Button20.Name = "guna2Button20";
            this.guna2Button20.Size = new System.Drawing.Size(86, 31);
            this.guna2Button20.TabIndex = 223;
            this.guna2Button20.Text = "Admin";
            // 
            // guna2Button12
            // 
            this.guna2Button12.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button12.BorderRadius = 1;
            this.guna2Button12.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Button12.BorderThickness = 1;
            this.guna2Button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button12.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button12.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button12.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button12.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.guna2Button12.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.guna2Button12.Location = new System.Drawing.Point(955, 6);
            this.guna2Button12.Name = "guna2Button12";
            this.guna2Button12.Size = new System.Drawing.Size(86, 31);
            this.guna2Button12.TabIndex = 221;
            this.guna2Button12.Text = "Email";
            this.guna2Button12.TextFormatNoPrefix = true;
            // 
            // guna2Button13
            // 
            this.guna2Button13.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button13.BorderRadius = 1;
            this.guna2Button13.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Button13.BorderThickness = 1;
            this.guna2Button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button13.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button13.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button13.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button13.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button13.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.guna2Button13.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.guna2Button13.Location = new System.Drawing.Point(1053, 6);
            this.guna2Button13.Name = "guna2Button13";
            this.guna2Button13.Size = new System.Drawing.Size(86, 31);
            this.guna2Button13.TabIndex = 220;
            this.guna2Button13.Text = "Claims";
            // 
            // guna2Button14
            // 
            this.guna2Button14.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button14.BorderRadius = 1;
            this.guna2Button14.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Button14.BorderThickness = 1;
            this.guna2Button14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button14.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button14.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button14.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button14.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button14.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.guna2Button14.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.guna2Button14.Location = new System.Drawing.Point(857, 6);
            this.guna2Button14.Name = "guna2Button14";
            this.guna2Button14.Size = new System.Drawing.Size(86, 31);
            this.guna2Button14.TabIndex = 219;
            this.guna2Button14.Text = "Users";
            // 
            // guna2Button15
            // 
            this.guna2Button15.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button15.BorderRadius = 1;
            this.guna2Button15.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Button15.BorderThickness = 1;
            this.guna2Button15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button15.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button15.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button15.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button15.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button15.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.guna2Button15.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.guna2Button15.Location = new System.Drawing.Point(759, 6);
            this.guna2Button15.Name = "guna2Button15";
            this.guna2Button15.Size = new System.Drawing.Size(86, 31);
            this.guna2Button15.TabIndex = 218;
            this.guna2Button15.Text = "Categories/Locations";
            // 
            // dGVUserManage
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dGVUserManage.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dGVUserManage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dGVUserManage.ColumnHeadersHeight = 4;
            this.dGVUserManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dGVUserManage.DefaultCellStyle = dataGridViewCellStyle3;
            this.dGVUserManage.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dGVUserManage.Location = new System.Drawing.Point(14, 89);
            this.dGVUserManage.Name = "dGVUserManage";
            this.dGVUserManage.RowHeadersVisible = false;
            this.dGVUserManage.Size = new System.Drawing.Size(1115, 537);
            this.dGVUserManage.TabIndex = 213;
            this.dGVUserManage.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dGVUserManage.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dGVUserManage.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dGVUserManage.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dGVUserManage.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dGVUserManage.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dGVUserManage.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dGVUserManage.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dGVUserManage.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dGVUserManage.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dGVUserManage.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dGVUserManage.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dGVUserManage.ThemeStyle.HeaderStyle.Height = 4;
            this.dGVUserManage.ThemeStyle.ReadOnly = false;
            this.dGVUserManage.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dGVUserManage.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dGVUserManage.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dGVUserManage.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dGVUserManage.ThemeStyle.RowsStyle.Height = 22;
            this.dGVUserManage.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dGVUserManage.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2HtmlLabel12
            // 
            this.guna2HtmlLabel12.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel12.Font = new System.Drawing.Font("Montserrat", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel12.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel12.Location = new System.Drawing.Point(438, 23);
            this.guna2HtmlLabel12.Name = "guna2HtmlLabel12";
            this.guna2HtmlLabel12.Size = new System.Drawing.Size(264, 50);
            this.guna2HtmlLabel12.TabIndex = 212;
            this.guna2HtmlLabel12.Text = "Manage Users";
            // 
            // tabEmailNotifications
            // 
            this.tabEmailNotifications.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.tabEmailNotifications.Controls.Add(this.btnAdmin);
            this.tabEmailNotifications.Controls.Add(this.guna2Button16);
            this.tabEmailNotifications.Controls.Add(this.guna2Button17);
            this.tabEmailNotifications.Controls.Add(this.guna2Button18);
            this.tabEmailNotifications.Controls.Add(this.guna2Button19);
            this.tabEmailNotifications.Location = new System.Drawing.Point(4, 22);
            this.tabEmailNotifications.Name = "tabEmailNotifications";
            this.tabEmailNotifications.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmailNotifications.Size = new System.Drawing.Size(1142, 634);
            this.tabEmailNotifications.TabIndex = 5;
            this.tabEmailNotifications.Text = "Email";
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnAdmin.BorderRadius = 1;
            this.btnAdmin.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.btnAdmin.BorderThickness = 1;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdmin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.btnAdmin.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.btnAdmin.Location = new System.Drawing.Point(669, 6);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(86, 31);
            this.btnAdmin.TabIndex = 222;
            this.btnAdmin.Text = "Admin";
            // 
            // guna2Button16
            // 
            this.guna2Button16.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button16.BorderRadius = 1;
            this.guna2Button16.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Button16.BorderThickness = 1;
            this.guna2Button16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button16.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button16.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button16.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button16.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button16.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.guna2Button16.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.guna2Button16.Location = new System.Drawing.Point(955, 6);
            this.guna2Button16.Name = "guna2Button16";
            this.guna2Button16.Size = new System.Drawing.Size(86, 31);
            this.guna2Button16.TabIndex = 221;
            this.guna2Button16.Text = "Email";
            this.guna2Button16.TextFormatNoPrefix = true;
            // 
            // guna2Button17
            // 
            this.guna2Button17.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button17.BorderRadius = 1;
            this.guna2Button17.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Button17.BorderThickness = 1;
            this.guna2Button17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button17.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button17.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button17.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button17.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button17.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.guna2Button17.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.guna2Button17.Location = new System.Drawing.Point(1051, 6);
            this.guna2Button17.Name = "guna2Button17";
            this.guna2Button17.Size = new System.Drawing.Size(86, 31);
            this.guna2Button17.TabIndex = 220;
            this.guna2Button17.Text = "Claims";
            // 
            // guna2Button18
            // 
            this.guna2Button18.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button18.BorderRadius = 1;
            this.guna2Button18.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Button18.BorderThickness = 1;
            this.guna2Button18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button18.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button18.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button18.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button18.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.guna2Button18.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.guna2Button18.Location = new System.Drawing.Point(859, 6);
            this.guna2Button18.Name = "guna2Button18";
            this.guna2Button18.Size = new System.Drawing.Size(86, 31);
            this.guna2Button18.TabIndex = 219;
            this.guna2Button18.Text = "Users";
            // 
            // guna2Button19
            // 
            this.guna2Button19.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button19.BorderRadius = 1;
            this.guna2Button19.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.guna2Button19.BorderThickness = 1;
            this.guna2Button19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button19.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button19.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button19.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button19.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button19.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.guna2Button19.Font = new System.Drawing.Font("Roboto Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.guna2Button19.Location = new System.Drawing.Point(761, 6);
            this.guna2Button19.Name = "guna2Button19";
            this.guna2Button19.Size = new System.Drawing.Size(86, 31);
            this.guna2Button19.TabIndex = 218;
            this.guna2Button19.Text = "Categories/Locations";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1150, 660);
            this.panel2.TabIndex = 0;
            // 
            // frmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 660);
            this.Controls.Add(this.tabControlLogin);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAdmin";
            this.Text = "frmAdmin";
            this.tabControlLogin.ResumeLayout(false);
            this.tabAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox3)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.tabUsers.ResumeLayout(false);
            this.tabUsers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVUserManage)).EndInit();
            this.tabEmailNotifications.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTabControl tabControlLogin;
        private System.Windows.Forms.TabPage tabAdmin;
        private Guna.UI2.WinForms.Guna2Button btnManageClaims;
        private Guna.UI2.WinForms.Guna2Button btnManageUsers;
        private Guna.UI2.WinForms.Guna2Button btnManageCat;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.TabPage tabUsers;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel12;
        private Guna.UI2.WinForms.Guna2DataGridView dGVUserManage;
        private System.Windows.Forms.TabPage tabEmailNotifications;
        private Guna.UI2.WinForms.Guna2Button btnManageEmails;
        private Guna.UI2.WinForms.Guna2Button guna2Button12;
        private Guna.UI2.WinForms.Guna2Button guna2Button13;
        private Guna.UI2.WinForms.Guna2Button guna2Button14;
        private Guna.UI2.WinForms.Guna2Button guna2Button15;
        private Guna.UI2.WinForms.Guna2Button guna2Button16;
        private Guna.UI2.WinForms.Guna2Button guna2Button17;
        private Guna.UI2.WinForms.Guna2Button guna2Button18;
        private Guna.UI2.WinForms.Guna2Button guna2Button19;
        private Guna.UI2.WinForms.Guna2Button btnAdmin;
        private Guna.UI2.WinForms.Guna2Button guna2Button20;
        private Guna.UI2.WinForms.Guna2Button btnAdminManage;
        private System.Windows.Forms.Panel panel2;
    }
}