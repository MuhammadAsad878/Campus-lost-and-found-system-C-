namespace CampusLostAndFoundSystem.Forms
{
    partial class frmManage
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
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtCategoryName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLocationName = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbLocationID = new System.Windows.Forms.ComboBox();
            this.cmbCatID = new System.Windows.Forms.ComboBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnCatDel = new Guna.UI2.WinForms.Guna2Button();
            this.btnCatNew = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnDelLoc = new Guna.UI2.WinForms.Guna2Button();
            this.btnNewLoc = new Guna.UI2.WinForms.Guna2Button();
            this.locationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(765, 58);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(161, 49);
            this.guna2HtmlLabel1.TabIndex = 215;
            this.guna2HtmlLabel1.Text = "Locations";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Controls.Add(this.txtCategoryName);
            this.guna2Panel4.Controls.Add(this.txtLocationName);
            this.guna2Panel4.Controls.Add(this.cmbLocationID);
            this.guna2Panel4.Controls.Add(this.cmbCatID);
            this.guna2Panel4.Controls.Add(this.lblMessage);
            this.guna2Panel4.Controls.Add(this.guna2HtmlLabel2);
            this.guna2Panel4.Controls.Add(this.guna2HtmlLabel5);
            this.guna2Panel4.Controls.Add(this.guna2HtmlLabel4);
            this.guna2Panel4.Controls.Add(this.btnCatDel);
            this.guna2Panel4.Controls.Add(this.btnCatNew);
            this.guna2Panel4.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel4.Controls.Add(this.guna2HtmlLabel7);
            this.guna2Panel4.Controls.Add(this.guna2HtmlLabel8);
            this.guna2Panel4.Controls.Add(this.btnDelLoc);
            this.guna2Panel4.Controls.Add(this.btnNewLoc);
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel4.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(1150, 660);
            this.guna2Panel4.TabIndex = 214;
            this.guna2Panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel4_Paint);
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategoryName.DefaultText = "";
            this.txtCategoryName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCategoryName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCategoryName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategoryName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCategoryName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategoryName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCategoryName.Location = new System.Drawing.Point(61, 221);
            this.txtCategoryName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.PasswordChar = '\0';
            this.txtCategoryName.PlaceholderText = "";
            this.txtCategoryName.SelectedText = "";
            this.txtCategoryName.Size = new System.Drawing.Size(432, 36);
            this.txtCategoryName.TabIndex = 229;
            // 
            // txtLocationName
            // 
            this.txtLocationName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocationName.DefaultText = "";
            this.txtLocationName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLocationName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLocationName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocationName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocationName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLocationName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLocationName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLocationName.Location = new System.Drawing.Point(596, 221);
            this.txtLocationName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLocationName.Name = "txtLocationName";
            this.txtLocationName.PasswordChar = '\0';
            this.txtLocationName.PlaceholderText = "";
            this.txtLocationName.SelectedText = "";
            this.txtLocationName.Size = new System.Drawing.Size(432, 36);
            this.txtLocationName.TabIndex = 228;
            // 
            // cmbLocationID
            // 
            this.cmbLocationID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbLocationID.Font = new System.Drawing.Font("Helvetica", 14.25F);
            this.cmbLocationID.FormattingEnabled = true;
            this.cmbLocationID.Location = new System.Drawing.Point(596, 149);
            this.cmbLocationID.MaxDropDownItems = 6;
            this.cmbLocationID.Name = "cmbLocationID";
            this.cmbLocationID.Size = new System.Drawing.Size(432, 30);
            this.cmbLocationID.TabIndex = 226;
            this.cmbLocationID.SelectedIndexChanged += new System.EventHandler(this.cmbLocationID_SelectedIndexChanged_1);
            // 
            // cmbCatID
            // 
            this.cmbCatID.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbCatID.Font = new System.Drawing.Font("Helvetica", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCatID.FormattingEnabled = true;
            this.cmbCatID.Location = new System.Drawing.Point(61, 149);
            this.cmbCatID.MaxDropDownItems = 6;
            this.cmbCatID.Name = "cmbCatID";
            this.cmbCatID.Size = new System.Drawing.Size(432, 30);
            this.cmbCatID.TabIndex = 225;
            this.cmbCatID.SelectedIndexChanged += new System.EventHandler(this.cmbCatID_SelectedIndexChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.ForeColor = System.Drawing.Color.Black;
            this.lblMessage.Location = new System.Drawing.Point(459, 27);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 22);
            this.lblMessage.TabIndex = 224;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Montserrat", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(207, 58);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(154, 49);
            this.guna2HtmlLabel2.TabIndex = 223;
            this.guna2HtmlLabel2.Text = "Category";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(61, 187);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(157, 28);
            this.guna2HtmlLabel5.TabIndex = 222;
            this.guna2HtmlLabel5.Text = "Category Name";
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(61, 115);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(120, 28);
            this.guna2HtmlLabel4.TabIndex = 220;
            this.guna2HtmlLabel4.Text = "Category ID";
            // 
            // btnCatDel
            // 
            this.btnCatDel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCatDel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCatDel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCatDel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCatDel.FillColor = System.Drawing.Color.Gray;
            this.btnCatDel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatDel.ForeColor = System.Drawing.Color.White;
            this.btnCatDel.Location = new System.Drawing.Point(281, 284);
            this.btnCatDel.Name = "btnCatDel";
            this.btnCatDel.Size = new System.Drawing.Size(119, 45);
            this.btnCatDel.TabIndex = 219;
            this.btnCatDel.Text = "Delete";
            this.btnCatDel.Click += new System.EventHandler(this.btnCatDel_Click);
            // 
            // btnCatNew
            // 
            this.btnCatNew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCatNew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCatNew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCatNew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCatNew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCatNew.ForeColor = System.Drawing.Color.White;
            this.btnCatNew.Location = new System.Drawing.Point(156, 284);
            this.btnCatNew.Name = "btnCatNew";
            this.btnCatNew.Size = new System.Drawing.Size(119, 45);
            this.btnCatNew.TabIndex = 218;
            this.btnCatNew.Text = "New";
            this.btnCatNew.Click += new System.EventHandler(this.btnCatNew_Click_1);
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(596, 187);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(152, 28);
            this.guna2HtmlLabel7.TabIndex = 211;
            this.guna2HtmlLabel7.Text = "Location Name";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(596, 115);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(115, 28);
            this.guna2HtmlLabel8.TabIndex = 209;
            this.guna2HtmlLabel8.Text = "Location ID";
            // 
            // btnDelLoc
            // 
            this.btnDelLoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelLoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelLoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelLoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelLoc.FillColor = System.Drawing.Color.Gray;
            this.btnDelLoc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelLoc.ForeColor = System.Drawing.Color.White;
            this.btnDelLoc.Location = new System.Drawing.Point(797, 284);
            this.btnDelLoc.Name = "btnDelLoc";
            this.btnDelLoc.Size = new System.Drawing.Size(119, 45);
            this.btnDelLoc.TabIndex = 3;
            this.btnDelLoc.Text = "Delete";
            this.btnDelLoc.Click += new System.EventHandler(this.btnDelLoc_Click);
            // 
            // btnNewLoc
            // 
            this.btnNewLoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNewLoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNewLoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNewLoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNewLoc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewLoc.ForeColor = System.Drawing.Color.White;
            this.btnNewLoc.Location = new System.Drawing.Point(672, 284);
            this.btnNewLoc.Name = "btnNewLoc";
            this.btnNewLoc.Size = new System.Drawing.Size(119, 45);
            this.btnNewLoc.TabIndex = 1;
            this.btnNewLoc.Text = "New";
            this.btnNewLoc.Click += new System.EventHandler(this.btnNewLoc_Click);
            // 
            // locationsBindingSource
            // 
            this.locationsBindingSource.DataMember = "Locations";
            // 
            // frmManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 660);
            this.Controls.Add(this.guna2Panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmManage";
            this.Text = "frmManage";
            this.Load += new System.EventHandler(this.frmCatLoc_Load);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2Button btnDelLoc;
        private Guna.UI2.WinForms.Guna2Button btnNewLoc;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2Button btnCatDel;
        private Guna.UI2.WinForms.Guna2Button btnCatNew;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.ComboBox cmbCatID;
        private System.Windows.Forms.ComboBox cmbLocationID;
        private System.Windows.Forms.BindingSource locationsBindingSource;
        private Guna.UI2.WinForms.Guna2TextBox txtLocationName;
        private Guna.UI2.WinForms.Guna2TextBox txtCategoryName;
    }
}