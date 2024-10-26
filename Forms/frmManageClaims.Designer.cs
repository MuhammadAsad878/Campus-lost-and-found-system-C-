namespace CampusLostAndFoundSystem.Forms
{
    partial class frmManageClaims
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpLostFoundDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnUpdateClaim = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtClaimID = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvClaimItems = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2HtmlLabel10 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.rdbA = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rdbP = new Guna.UI2.WinForms.Guna2RadioButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClaimItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpLostFoundDate
            // 
            this.dtpLostFoundDate.BorderRadius = 5;
            this.dtpLostFoundDate.Checked = true;
            this.dtpLostFoundDate.FillColor = System.Drawing.Color.Silver;
            this.dtpLostFoundDate.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpLostFoundDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpLostFoundDate.Location = new System.Drawing.Point(319, 91);
            this.dtpLostFoundDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpLostFoundDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpLostFoundDate.Name = "dtpLostFoundDate";
            this.dtpLostFoundDate.Size = new System.Drawing.Size(464, 36);
            this.dtpLostFoundDate.TabIndex = 308;
            this.dtpLostFoundDate.Value = new System.DateTime(2024, 6, 15, 0, 8, 55, 248);
            // 
            // btnUpdateClaim
            // 
            this.btnUpdateClaim.BorderColor = System.Drawing.Color.Transparent;
            this.btnUpdateClaim.BorderRadius = 5;
            this.btnUpdateClaim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdateClaim.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateClaim.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateClaim.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateClaim.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateClaim.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(180)))), ((int)(((byte)(216)))));
            this.btnUpdateClaim.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnUpdateClaim.ForeColor = System.Drawing.Color.White;
            this.btnUpdateClaim.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnUpdateClaim.Location = new System.Drawing.Point(81, 245);
            this.btnUpdateClaim.Name = "btnUpdateClaim";
            this.btnUpdateClaim.Size = new System.Drawing.Size(464, 42);
            this.btnUpdateClaim.TabIndex = 307;
            this.btnUpdateClaim.Text = "Update";
            this.btnUpdateClaim.Click += new System.EventHandler(this.btnUpdateClaim_Click);
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(319, 70);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(76, 19);
            this.guna2HtmlLabel6.TabIndex = 306;
            this.guna2HtmlLabel6.Text = "Claim Date";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(81, 70);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(60, 19);
            this.guna2HtmlLabel2.TabIndex = 303;
            this.guna2HtmlLabel2.Text = "Claim ID";
            // 
            // txtClaimID
            // 
            this.txtClaimID.BorderRadius = 5;
            this.txtClaimID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClaimID.DefaultText = "";
            this.txtClaimID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtClaimID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtClaimID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClaimID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtClaimID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClaimID.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaimID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtClaimID.Location = new System.Drawing.Point(81, 91);
            this.txtClaimID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClaimID.Name = "txtClaimID";
            this.txtClaimID.PasswordChar = '\0';
            this.txtClaimID.PlaceholderText = "";
            this.txtClaimID.SelectedText = "";
            this.txtClaimID.Size = new System.Drawing.Size(200, 36);
            this.txtClaimID.TabIndex = 302;
            // 
            // dgvClaimItems
            // 
            this.dgvClaimItems.AllowUserToAddRows = false;
            this.dgvClaimItems.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvClaimItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClaimItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClaimItems.ColumnHeadersHeight = 30;
            this.dgvClaimItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClaimItems.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvClaimItems.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.dgvClaimItems.Location = new System.Drawing.Point(12, 321);
            this.dgvClaimItems.Name = "dgvClaimItems";
            this.dgvClaimItems.ReadOnly = true;
            this.dgvClaimItems.RowHeadersVisible = false;
            this.dgvClaimItems.Size = new System.Drawing.Size(1126, 327);
            this.dgvClaimItems.TabIndex = 299;
            this.dgvClaimItems.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvClaimItems.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvClaimItems.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvClaimItems.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvClaimItems.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvClaimItems.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvClaimItems.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.dgvClaimItems.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvClaimItems.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvClaimItems.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClaimItems.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvClaimItems.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvClaimItems.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvClaimItems.ThemeStyle.ReadOnly = true;
            this.dgvClaimItems.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvClaimItems.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClaimItems.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClaimItems.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvClaimItems.ThemeStyle.RowsStyle.Height = 22;
            this.dgvClaimItems.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvClaimItems.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvClaimItems.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClaimItems_CellClick);
            // 
            // guna2HtmlLabel10
            // 
            this.guna2HtmlLabel10.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel10.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.guna2HtmlLabel10.Location = new System.Drawing.Point(470, 1);
            this.guna2HtmlLabel10.Name = "guna2HtmlLabel10";
            this.guna2HtmlLabel10.Size = new System.Drawing.Size(221, 39);
            this.guna2HtmlLabel10.TabIndex = 298;
            this.guna2HtmlLabel10.Text = "Manage Claims";
            // 
            // rdbA
            // 
            this.rdbA.AutoSize = true;
            this.rdbA.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbA.CheckedState.BorderThickness = 0;
            this.rdbA.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbA.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbA.CheckedState.InnerOffset = -4;
            this.rdbA.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbA.Location = new System.Drawing.Point(233, 172);
            this.rdbA.Name = "rdbA";
            this.rdbA.Size = new System.Drawing.Size(112, 26);
            this.rdbA.TabIndex = 312;
            this.rdbA.Text = "Approved";
            this.rdbA.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbA.UncheckedState.BorderThickness = 2;
            this.rdbA.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbA.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rdbP
            // 
            this.rdbP.AutoSize = true;
            this.rdbP.Checked = true;
            this.rdbP.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbP.CheckedState.BorderThickness = 0;
            this.rdbP.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdbP.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdbP.CheckedState.InnerOffset = -4;
            this.rdbP.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbP.Location = new System.Drawing.Point(82, 172);
            this.rdbP.Name = "rdbP";
            this.rdbP.Size = new System.Drawing.Size(100, 26);
            this.rdbP.TabIndex = 309;
            this.rdbP.TabStop = true;
            this.rdbP.Text = "Pending";
            this.rdbP.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdbP.UncheckedState.BorderThickness = 2;
            this.rdbP.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdbP.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Helvetica", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(83, 147);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(87, 19);
            this.guna2HtmlLabel1.TabIndex = 313;
            this.guna2HtmlLabel1.Text = "Claim Status";
            // 
            // frmManageClaims
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 660);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.rdbA);
            this.Controls.Add(this.rdbP);
            this.Controls.Add(this.dtpLostFoundDate);
            this.Controls.Add(this.btnUpdateClaim);
            this.Controls.Add(this.guna2HtmlLabel6);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.txtClaimID);
            this.Controls.Add(this.dgvClaimItems);
            this.Controls.Add(this.guna2HtmlLabel10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmManageClaims";
            this.Text = "frmManageClaims";
            ((System.ComponentModel.ISupportInitialize)(this.dgvClaimItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpLostFoundDate;
        private Guna.UI2.WinForms.Guna2Button btnUpdateClaim;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2TextBox txtClaimID;
        private Guna.UI2.WinForms.Guna2DataGridView dgvClaimItems;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel10;
        private Guna.UI2.WinForms.Guna2RadioButton rdbA;
        private Guna.UI2.WinForms.Guna2RadioButton rdbP;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}