namespace CampusLostAndFoundSystem.Forms
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel7 = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.pbMain = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txtUNameMain = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlParent = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.subPnlReport = new Guna.UI2.WinForms.Guna2Panel();
            this.btnMyClaims = new Guna.UI2.WinForms.Guna2Button();
            this.btnMyProfile = new Guna.UI2.WinForms.Guna2Button();
            this.btnNewReport = new Guna.UI2.WinForms.Guna2Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.pnlSideBar.SuspendLayout();
            this.subPnlReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.guna2PictureBox1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(298, 100);
            this.panel2.TabIndex = 213;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(101, 100);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 215;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Montserrat SemiBold", 9.749999F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(100, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 18);
            this.label7.TabIndex = 56;
            this.label7.Text = "Lost-And-Found";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(100, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 18);
            this.label8.TabIndex = 58;
            this.label8.Text = "IUB ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Montserrat", 9.749999F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(159, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 18);
            this.label9.TabIndex = 57;
            this.label9.Text = "System";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.panel7.Controls.Add(this.guna2HtmlLabel1);
            this.panel7.Controls.Add(this.lblID);
            this.panel7.Controls.Add(this.btnExit);
            this.panel7.Controls.Add(this.pbMain);
            this.panel7.Controls.Add(this.txtUNameMain);
            this.panel7.Controls.Add(this.guna2HtmlLabel3);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Controls.Add(this.guna2HtmlLabel2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1476, 100);
            this.panel7.TabIndex = 213;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(1284, 29);
            this.guna2HtmlLabel1.MaximumSize = new System.Drawing.Size(75, 20);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(12, 20);
            this.guna2HtmlLabel1.TabIndex = 226;
            this.guna2HtmlLabel1.Text = "#";
            // 
            // lblID
            // 
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.Black;
            this.lblID.Location = new System.Drawing.Point(1293, 29);
            this.lblID.MaximumSize = new System.Drawing.Size(75, 20);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(33, 20);
            this.lblID.TabIndex = 225;
            this.lblID.Text = "------";
            // 
            // btnExit
            // 
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(240)))), ((int)(((byte)(248)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.HoverState.CustomBorderColor = System.Drawing.Color.Black;
            this.btnExit.HoverState.FillColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(1407, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.PressedColor = System.Drawing.Color.Red;
            this.btnExit.Size = new System.Drawing.Size(69, 28);
            this.btnExit.TabIndex = 26;
            this.btnExit.Text = "X";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbMain
            // 
            this.pbMain.BackColor = System.Drawing.Color.Transparent;
            this.pbMain.Image = ((System.Drawing.Image)(resources.GetObject("pbMain.Image")));
            this.pbMain.ImageRotate = 0F;
            this.pbMain.Location = new System.Drawing.Point(1227, 28);
            this.pbMain.Name = "pbMain";
            this.pbMain.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbMain.Size = new System.Drawing.Size(51, 52);
            this.pbMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMain.TabIndex = 223;
            this.pbMain.TabStop = false;
            this.pbMain.UseTransparentBackground = true;
            // 
            // txtUNameMain
            // 
            this.txtUNameMain.BackColor = System.Drawing.Color.Transparent;
            this.txtUNameMain.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUNameMain.ForeColor = System.Drawing.Color.Black;
            this.txtUNameMain.Location = new System.Drawing.Point(1284, 59);
            this.txtUNameMain.MaximumSize = new System.Drawing.Size(75, 20);
            this.txtUNameMain.Name = "txtUNameMain";
            this.txtUNameMain.Size = new System.Drawing.Size(45, 20);
            this.txtUNameMain.TabIndex = 224;
            this.txtUNameMain.Text = "------";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(656, 55);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(153, 25);
            this.guna2HtmlLabel3.TabIndex = 214;
            this.guna2HtmlLabel3.Text = "Baghdad Campus";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Roboto Black", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(577, 22);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(331, 40);
            this.guna2HtmlLabel2.TabIndex = 55;
            this.guna2HtmlLabel2.Text = "Lost and found system";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.panel7);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1476, 100);
            this.guna2Panel3.TabIndex = 214;
            // 
            // pnlParent
            // 
            this.pnlParent.AutoScroll = true;
            this.pnlParent.BackColor = System.Drawing.Color.Transparent;
            this.pnlParent.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlParent.Location = new System.Drawing.Point(277, 100);
            this.pnlParent.Name = "pnlParent";
            this.pnlParent.Size = new System.Drawing.Size(1199, 664);
            this.pnlParent.TabIndex = 218;
            this.pnlParent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlParent_Paint);
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.AutoScroll = true;
            this.pnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.pnlSideBar.Controls.Add(this.guna2Button1);
            this.pnlSideBar.Controls.Add(this.subPnlReport);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 100);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(277, 664);
            this.pnlSideBar.TabIndex = 1;
            // 
            // subPnlReport
            // 
            this.subPnlReport.Controls.Add(this.btnMyClaims);
            this.subPnlReport.Controls.Add(this.btnMyProfile);
            this.subPnlReport.Controls.Add(this.btnNewReport);
            this.subPnlReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.subPnlReport.Location = new System.Drawing.Point(0, 0);
            this.subPnlReport.Name = "subPnlReport";
            this.subPnlReport.Size = new System.Drawing.Size(277, 495);
            this.subPnlReport.TabIndex = 1;
            // 
            // btnMyClaims
            // 
            this.btnMyClaims.AutoRoundedCorners = true;
            this.btnMyClaims.BackColor = System.Drawing.Color.Transparent;
            this.btnMyClaims.BorderColor = System.Drawing.Color.Transparent;
            this.btnMyClaims.BorderRadius = 37;
            this.btnMyClaims.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyClaims.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMyClaims.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMyClaims.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMyClaims.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMyClaims.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnMyClaims.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyClaims.ForeColor = System.Drawing.Color.White;
            this.btnMyClaims.HoverState.FillColor = System.Drawing.Color.AliceBlue;
            this.btnMyClaims.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnMyClaims.Location = new System.Drawing.Point(23, 301);
            this.btnMyClaims.Name = "btnMyClaims";
            this.btnMyClaims.Size = new System.Drawing.Size(229, 77);
            this.btnMyClaims.TabIndex = 5;
            this.btnMyClaims.Text = "Check & Claim";
            this.btnMyClaims.TextFormatNoPrefix = true;
            this.btnMyClaims.Click += new System.EventHandler(this.btnMyClaims_Click_1);
            // 
            // btnMyProfile
            // 
            this.btnMyProfile.AutoRoundedCorners = true;
            this.btnMyProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnMyProfile.BorderColor = System.Drawing.Color.Transparent;
            this.btnMyProfile.BorderRadius = 37;
            this.btnMyProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyProfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMyProfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMyProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMyProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMyProfile.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnMyProfile.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyProfile.ForeColor = System.Drawing.Color.White;
            this.btnMyProfile.HoverState.FillColor = System.Drawing.Color.AliceBlue;
            this.btnMyProfile.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnMyProfile.Location = new System.Drawing.Point(23, 135);
            this.btnMyProfile.Name = "btnMyProfile";
            this.btnMyProfile.Size = new System.Drawing.Size(232, 77);
            this.btnMyProfile.TabIndex = 6;
            this.btnMyProfile.Text = "My Profile";
            this.btnMyProfile.Click += new System.EventHandler(this.btnMyProfile_Click_1);
            // 
            // btnNewReport
            // 
            this.btnNewReport.AutoRoundedCorners = true;
            this.btnNewReport.BackColor = System.Drawing.Color.Transparent;
            this.btnNewReport.BorderColor = System.Drawing.Color.Transparent;
            this.btnNewReport.BorderRadius = 37;
            this.btnNewReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewReport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNewReport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNewReport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNewReport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNewReport.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnNewReport.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewReport.ForeColor = System.Drawing.Color.White;
            this.btnNewReport.HoverState.FillColor = System.Drawing.Color.AliceBlue;
            this.btnNewReport.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnNewReport.Image = global::CampusLostAndFoundSystem.Properties.Resources.plus_circle_fill_01;
            this.btnNewReport.Location = new System.Drawing.Point(23, 218);
            this.btnNewReport.Name = "btnNewReport";
            this.btnNewReport.Size = new System.Drawing.Size(232, 77);
            this.btnNewReport.TabIndex = 4;
            this.btnNewReport.Text = "New Report";
            this.btnNewReport.Click += new System.EventHandler(this.btnNewReport_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Silver;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Button1.FillColor = System.Drawing.Color.Gray;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(0, 619);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(277, 45);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "Logout";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1476, 764);
            this.Controls.Add(this.pnlSideBar);
            this.Controls.Add(this.pnlParent);
            this.Controls.Add(this.guna2Panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.pnlSideBar.ResumeLayout(false);
            this.subPnlReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Panel panel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlParent;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private System.Windows.Forms.Panel pnlSideBar;
        private Guna.UI2.WinForms.Guna2Button btnNewReport;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbMain;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtUNameMain;
        private Guna.UI2.WinForms.Guna2Button btnMyClaims;
        private Guna.UI2.WinForms.Guna2Panel subPnlReport;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblID;
        private Guna.UI2.WinForms.Guna2Button btnMyProfile;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}