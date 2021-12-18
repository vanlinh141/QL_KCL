namespace QL_KCL
{
    partial class AccountForm
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
            this.BtnDelete = new System.Windows.Forms.Button();
            this.panelSideRight = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtStaff = new System.Windows.Forms.Label();
            this.gridStaff = new System.Windows.Forms.DataGridView();
            this.panelControl = new System.Windows.Forms.Panel();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.txtStatusEmail = new System.Windows.Forms.Label();
            this.panelConfirm = new System.Windows.Forms.Panel();
            this.txtConfirm = new System.Windows.Forms.Label();
            this.BtnTogglePassword = new System.Windows.Forms.Button();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.txtStatusPassword = new System.Windows.Forms.Label();
            this.boxConfirm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.Label();
            this.boxPassword = new System.Windows.Forms.TextBox();
            this.boxEmail = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.boxID = new System.Windows.Forms.TextBox();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.Label();
            this.gridAccount = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStaff)).BeginInit();
            this.panelControl.SuspendLayout();
            this.panelEmail.SuspendLayout();
            this.panelConfirm.SuspendLayout();
            this.panelPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BtnDelete.Location = new System.Drawing.Point(330, 263);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(136, 34);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "Xóa tài khoản";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // panelSideRight
            // 
            this.panelSideRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSideRight.Location = new System.Drawing.Point(1057, 0);
            this.panelSideRight.Name = "panelSideRight";
            this.panelSideRight.Size = new System.Drawing.Size(23, 627);
            this.panelSideRight.TabIndex = 1;
            // 
            // panelFooter
            // 
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 606);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1057, 21);
            this.panelFooter.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtStaff);
            this.panel3.Controls.Add(this.gridStaff);
            this.panel3.Controls.Add(this.panelControl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1057, 341);
            this.panel3.TabIndex = 3;
            // 
            // txtStaff
            // 
            this.txtStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStaff.AutoSize = true;
            this.txtStaff.Location = new System.Drawing.Point(768, 31);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.Size = new System.Drawing.Size(238, 16);
            this.txtStaff.TabIndex = 11;
            this.txtStaff.Text = "Danh sách nhân viên chưa có tài khoản";
            // 
            // gridStaff
            // 
            this.gridStaff.AllowUserToAddRows = false;
            this.gridStaff.AllowUserToDeleteRows = false;
            this.gridStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gridStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStaff.Location = new System.Drawing.Point(527, 60);
            this.gridStaff.Name = "gridStaff";
            this.gridStaff.ReadOnly = true;
            this.gridStaff.RowHeadersVisible = false;
            this.gridStaff.RowHeadersWidth = 51;
            this.gridStaff.RowTemplate.Height = 24;
            this.gridStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridStaff.Size = new System.Drawing.Size(530, 249);
            this.gridStaff.TabIndex = 6;
            // 
            // panelControl
            // 
            this.panelControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl.Controls.Add(this.panelEmail);
            this.panelControl.Controls.Add(this.panelConfirm);
            this.panelControl.Controls.Add(this.BtnTogglePassword);
            this.panelControl.Controls.Add(this.panelPassword);
            this.panelControl.Controls.Add(this.boxConfirm);
            this.panelControl.Controls.Add(this.label1);
            this.panelControl.Controls.Add(this.txtPass);
            this.panelControl.Controls.Add(this.boxPassword);
            this.panelControl.Controls.Add(this.boxEmail);
            this.panelControl.Controls.Add(this.txtEmail);
            this.panelControl.Controls.Add(this.BtnDelete);
            this.panelControl.Controls.Add(this.BtnAdd);
            this.panelControl.Controls.Add(this.boxID);
            this.panelControl.Controls.Add(this.BtnEdit);
            this.panelControl.Controls.Add(this.txtID);
            this.panelControl.Location = new System.Drawing.Point(21, 12);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(469, 311);
            this.panelControl.TabIndex = 10;
            // 
            // panelEmail
            // 
            this.panelEmail.Controls.Add(this.txtStatusEmail);
            this.panelEmail.Location = new System.Drawing.Point(183, 87);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Size = new System.Drawing.Size(237, 17);
            this.panelEmail.TabIndex = 17;
            // 
            // txtStatusEmail
            // 
            this.txtStatusEmail.AutoSize = true;
            this.txtStatusEmail.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtStatusEmail.Location = new System.Drawing.Point(0, 0);
            this.txtStatusEmail.Name = "txtStatusEmail";
            this.txtStatusEmail.Size = new System.Drawing.Size(0, 16);
            this.txtStatusEmail.TabIndex = 0;
            // 
            // panelConfirm
            // 
            this.panelConfirm.Controls.Add(this.txtConfirm);
            this.panelConfirm.Location = new System.Drawing.Point(181, 232);
            this.panelConfirm.Name = "panelConfirm";
            this.panelConfirm.Size = new System.Drawing.Size(239, 17);
            this.panelConfirm.TabIndex = 16;
            // 
            // txtConfirm
            // 
            this.txtConfirm.AutoSize = true;
            this.txtConfirm.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtConfirm.Location = new System.Drawing.Point(0, 0);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(0, 16);
            this.txtConfirm.TabIndex = 0;
            // 
            // BtnTogglePassword
            // 
            this.BtnTogglePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTogglePassword.Location = new System.Drawing.Point(358, 130);
            this.BtnTogglePassword.Name = "BtnTogglePassword";
            this.BtnTogglePassword.Size = new System.Drawing.Size(61, 29);
            this.BtnTogglePassword.TabIndex = 15;
            this.BtnTogglePassword.Text = "Hiện";
            this.BtnTogglePassword.UseVisualStyleBackColor = true;
            this.BtnTogglePassword.Click += new System.EventHandler(this.BtnTogglePassword_Click);
            // 
            // panelPassword
            // 
            this.panelPassword.Controls.Add(this.txtStatusPassword);
            this.panelPassword.Location = new System.Drawing.Point(181, 164);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(238, 17);
            this.panelPassword.TabIndex = 13;
            // 
            // txtStatusPassword
            // 
            this.txtStatusPassword.AutoSize = true;
            this.txtStatusPassword.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtStatusPassword.Location = new System.Drawing.Point(0, 0);
            this.txtStatusPassword.Name = "txtStatusPassword";
            this.txtStatusPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStatusPassword.Size = new System.Drawing.Size(0, 16);
            this.txtStatusPassword.TabIndex = 12;
            // 
            // boxConfirm
            // 
            this.boxConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.boxConfirm.Location = new System.Drawing.Point(180, 202);
            this.boxConfirm.Name = "boxConfirm";
            this.boxConfirm.PasswordChar = '*';
            this.boxConfirm.ShortcutsEnabled = false;
            this.boxConfirm.Size = new System.Drawing.Size(239, 22);
            this.boxConfirm.TabIndex = 3;
            this.boxConfirm.TextChanged += new System.EventHandler(this.boxConfirm_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Xác nhận mật khẩu";
            // 
            // txtPass
            // 
            this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtPass.AutoSize = true;
            this.txtPass.Location = new System.Drawing.Point(26, 136);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(61, 16);
            this.txtPass.TabIndex = 8;
            this.txtPass.Text = "Mật khẩu";
            // 
            // boxPassword
            // 
            this.boxPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.boxPassword.Location = new System.Drawing.Point(181, 133);
            this.boxPassword.Name = "boxPassword";
            this.boxPassword.PasswordChar = '*';
            this.boxPassword.Size = new System.Drawing.Size(171, 22);
            this.boxPassword.TabIndex = 2;
            this.boxPassword.TextChanged += new System.EventHandler(this.boxPassword_TextChanged);
            // 
            // boxEmail
            // 
            this.boxEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.boxEmail.Location = new System.Drawing.Point(182, 54);
            this.boxEmail.Name = "boxEmail";
            this.boxEmail.Size = new System.Drawing.Size(238, 22);
            this.boxEmail.TabIndex = 1;
            this.boxEmail.TextChanged += new System.EventHandler(this.boxEmail_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(26, 57);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(41, 16);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Text = "Email";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BtnAdd.Location = new System.Drawing.Point(29, 263);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(136, 34);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Thêm tài khoản";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // boxID
            // 
            this.boxID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.boxID.Location = new System.Drawing.Point(181, 11);
            this.boxID.Name = "boxID";
            this.boxID.Size = new System.Drawing.Size(238, 22);
            this.boxID.TabIndex = 0;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BtnEdit.Location = new System.Drawing.Point(180, 263);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(136, 34);
            this.BtnEdit.TabIndex = 5;
            this.BtnEdit.Text = "Chỉnh sửa";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtID.AutoSize = true;
            this.txtID.Location = new System.Drawing.Point(26, 14);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(86, 16);
            this.txtID.TabIndex = 3;
            this.txtID.Text = "Mã nhân viên";
            // 
            // gridAccount
            // 
            this.gridAccount.AllowUserToAddRows = false;
            this.gridAccount.AllowUserToDeleteRows = false;
            this.gridAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAccount.Location = new System.Drawing.Point(0, 341);
            this.gridAccount.Name = "gridAccount";
            this.gridAccount.ReadOnly = true;
            this.gridAccount.RowHeadersVisible = false;
            this.gridAccount.RowHeadersWidth = 51;
            this.gridAccount.RowTemplate.Height = 24;
            this.gridAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAccount.Size = new System.Drawing.Size(1057, 265);
            this.gridAccount.TabIndex = 4;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 627);
            this.Controls.Add(this.gridAccount);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelSideRight);
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.Load += new System.EventHandler(this.AccountForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStaff)).EndInit();
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.panelEmail.ResumeLayout(false);
            this.panelEmail.PerformLayout();
            this.panelConfirm.ResumeLayout(false);
            this.panelConfirm.PerformLayout();
            this.panelPassword.ResumeLayout(false);
            this.panelPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Panel panelSideRight;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView gridAccount;
        private System.Windows.Forms.TextBox boxPassword;
        private System.Windows.Forms.Label txtPass;
        private System.Windows.Forms.TextBox boxEmail;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.DataGridView gridStaff;
        private System.Windows.Forms.TextBox boxID;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Label txtStaff;
        private System.Windows.Forms.TextBox boxConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtStatusPassword;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.Button BtnTogglePassword;
        private System.Windows.Forms.Panel panelConfirm;
        private System.Windows.Forms.Label txtConfirm;
        private System.Windows.Forms.Panel panelEmail;
        private System.Windows.Forms.Label txtStatusEmail;
    }
}