namespace CampusLostAndFoundSystem.Forms
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnAccess = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageClaims = new Guna.UI2.WinForms.Guna2Button();
            this.btnManageCat = new Guna.UI2.WinForms.Guna2Button();
            this.pbMain = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnAdmin = new Guna.UI2.WinForms.Guna2Button();
            this.subPnlAdmin = new System.Windows.Forms.Panel();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnlParent = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.txtUNameMain = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).BeginInit();
            this.subPnlAdmin.SuspendLayout();
            this.pnlSideBar.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2Panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAccess
            // 
            this.btnAccess.AutoRoundedCorners = true;
            this.btnAccess.BackColor = System.Drawing.Color.Transparent;
            this.btnAccess.BorderColor = System.Drawing.Color.Transparent;
            this.btnAccess.BorderRadius = 37;
            this.btnAccess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccess.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAccess.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAccess.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccess.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAccess.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnAccess.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccess.ForeColor = System.Drawing.Color.White;
            this.btnAccess.HoverState.FillColor = System.Drawing.Color.AliceBlue;
            this.btnAccess.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnAccess.Location = new System.Drawing.Point(21, 97);
            this.btnAccess.Name = "btnAccess";
            this.btnAccess.Size = new System.Drawing.Size(232, 77);
            this.btnAccess.TabIndex = 5;
            this.btnAccess.Text = "Manage Access";
            this.btnAccess.Click += new System.EventHandler(this.btnAccess_Click);
            // 
            // btnManageClaims
            // 
            this.btnManageClaims.AutoRoundedCorners = true;
            this.btnManageClaims.BackColor = System.Drawing.Color.Transparent;
            this.btnManageClaims.BorderColor = System.Drawing.Color.Transparent;
            this.btnManageClaims.BorderRadius = 37;
            this.btnManageClaims.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageClaims.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageClaims.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageClaims.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageClaims.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageClaims.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnManageClaims.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageClaims.ForeColor = System.Drawing.Color.White;
            this.btnManageClaims.HoverState.FillColor = System.Drawing.Color.AliceBlue;
            this.btnManageClaims.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnManageClaims.Location = new System.Drawing.Point(21, 263);
            this.btnManageClaims.Name = "btnManageClaims";
            this.btnManageClaims.Size = new System.Drawing.Size(232, 77);
            this.btnManageClaims.TabIndex = 2;
            this.btnManageClaims.Text = "Manage Claims";
            this.btnManageClaims.Click += new System.EventHandler(this.btnManageClaims_Click);
            // 
            // btnManageCat
            // 
            this.btnManageCat.AutoRoundedCorners = true;
            this.btnManageCat.BackColor = System.Drawing.Color.Transparent;
            this.btnManageCat.BorderColor = System.Drawing.Color.Transparent;
            this.btnManageCat.BorderRadius = 37;
            this.btnManageCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageCat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnManageCat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnManageCat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnManageCat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnManageCat.FillColor = System.Drawing.Color.DodgerBlue;
            this.btnManageCat.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCat.ForeColor = System.Drawing.Color.White;
            this.btnManageCat.HoverState.FillColor = System.Drawing.Color.AliceBlue;
            this.btnManageCat.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnManageCat.Location = new System.Drawing.Point(21, 180);
            this.btnManageCat.Name = "btnManageCat";
            this.btnManageCat.Size = new System.Drawing.Size(232, 77);
            this.btnManageCat.TabIndex = 0;
            this.btnManageCat.Text = "Categories & Locations";
            this.btnManageCat.TextFormatNoPrefix = true;
            this.btnManageCat.Click += new System.EventHandler(this.btnManageCat_Click);
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
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(190)))), ((int)(((byte)(249)))));
            this.btnAdmin.BorderColor = System.Drawing.Color.BlueViolet;
            this.btnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdmin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdmin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdmin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdmin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAdmin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(119)))), ((int)(((byte)(182)))));
            this.btnAdmin.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdmin.ForeColor = System.Drawing.Color.White;
            this.btnAdmin.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdmin.HoverState.ForeColor = System.Drawing.Color.Black;
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdmin.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAdmin.Location = new System.Drawing.Point(0, 0);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(277, 80);
            this.btnAdmin.TabIndex = 3;
            this.btnAdmin.Text = "Administrator";
            this.btnAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAdmin.TextOffset = new System.Drawing.Point(15, 0);
            // 
            // subPnlAdmin
            // 
            this.subPnlAdmin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.subPnlAdmin.Controls.Add(this.btnAdmin);
            this.subPnlAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.subPnlAdmin.Location = new System.Drawing.Point(0, 0);
            this.subPnlAdmin.Name = "subPnlAdmin";
            this.subPnlAdmin.Size = new System.Drawing.Size(277, 80);
            this.subPnlAdmin.TabIndex = 0;
            this.subPnlAdmin.Visible = false;
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.AutoScroll = true;
            this.pnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.pnlSideBar.Controls.Add(this.btnManageClaims);
            this.pnlSideBar.Controls.Add(this.btnManageCat);
            this.pnlSideBar.Controls.Add(this.btnAccess);
            this.pnlSideBar.Controls.Add(this.subPnlAdmin);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 100);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(277, 664);
            this.pnlSideBar.TabIndex = 219;
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
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
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
            // pnlParent
            // 
            this.pnlParent.AutoScroll = true;
            this.pnlParent.BackColor = System.Drawing.Color.Transparent;
            this.pnlParent.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlParent.Location = new System.Drawing.Point(277, 100);
            this.pnlParent.Name = "pnlParent";
            this.pnlParent.Size = new System.Drawing.Size(1199, 664);
            this.pnlParent.TabIndex = 221;
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.panel7);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(1476, 100);
            this.guna2Panel3.TabIndex = 220;
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
            // txtUNameMain
            // 
            this.txtUNameMain.BackColor = System.Drawing.Color.Transparent;
            this.txtUNameMain.Font = new System.Drawing.Font("Roboto Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUNameMain.ForeColor = System.Drawing.Color.Black;
            this.txtUNameMain.Location = new System.Drawing.Point(1284, 44);
            this.txtUNameMain.MaximumSize = new System.Drawing.Size(75, 20);
            this.txtUNameMain.Name = "txtUNameMain";
            this.txtUNameMain.Size = new System.Drawing.Size(50, 20);
            this.txtUNameMain.TabIndex = 224;
            this.txtUNameMain.Text = "Admin";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 764);
            this.Controls.Add(this.pnlSideBar);
            this.Controls.Add(this.pnlParent);
            this.Controls.Add(this.guna2Panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            ((System.ComponentModel.ISupportInitialize)(this.pbMain)).EndInit();
            this.subPnlAdmin.ResumeLayout(false);
            this.pnlSideBar.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2Panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button btnAccess;
        private Guna.UI2.WinForms.Guna2Button btnManageClaims;
        private Guna.UI2.WinForms.Guna2Button btnManageCat;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbMain;
        private Guna.UI2.WinForms.Guna2Button btnAdmin;
        private System.Windows.Forms.Panel subPnlAdmin;
        private System.Windows.Forms.Panel pnlSideBar;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2GradientPanel pnlParent;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2HtmlLabel txtUNameMain;
    }
}