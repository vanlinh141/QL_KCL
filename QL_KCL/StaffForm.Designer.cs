namespace QL_KCL
{
    partial class StaffForm
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
            this.BtnAdd = new System.Windows.Forms.Button();
            this.panelSideRight = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelControl = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.Label();
            this.boxID = new System.Windows.Forms.TextBox();
            this.boxPartial = new System.Windows.Forms.TextBox();
            this.txtPartial = new System.Windows.Forms.Label();
            this.boxAddress = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.Label();
            this.boxPhone = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.Label();
            this.boxCMND = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.Label();
            this.dateInPicker = new System.Windows.Forms.DateTimePicker();
            this.txtDateIn = new System.Windows.Forms.Label();
            this.cbBoxRole = new System.Windows.Forms.ComboBox();
            this.txtRole = new System.Windows.Forms.Label();
            this.birthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.txtBirthday = new System.Windows.Forms.Label();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.txtGender = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.Label();
            this.boxName = new System.Windows.Forms.TextBox();
            this.txtFirstname = new System.Windows.Forms.Label();
            this.boxFirstname = new System.Windows.Forms.TextBox();
            this.gridStaff = new System.Windows.Forms.DataGridView();
            this.kclSelected = new QL_KCL.KCLSelected();
            this.panel1.SuspendLayout();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStaff)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.Location = new System.Drawing.Point(889, 27);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(133, 35);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Thêm nhân viên";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // panelSideRight
            // 
            this.panelSideRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSideRight.Location = new System.Drawing.Point(1022, 0);
            this.panelSideRight.Name = "panelSideRight";
            this.panelSideRight.Size = new System.Drawing.Size(22, 637);
            this.panelSideRight.TabIndex = 1;
            // 
            // panelBottom
            // 
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 619);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1022, 18);
            this.panelBottom.TabIndex = 2;
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.Location = new System.Drawing.Point(889, 83);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(133, 35);
            this.BtnEdit.TabIndex = 1;
            this.BtnEdit.Text = "Chỉnh sửa";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Location = new System.Drawing.Point(889, 260);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(133, 35);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "Xóa nhân viên";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearch.Location = new System.Drawing.Point(889, 143);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(133, 35);
            this.BtnSearch.TabIndex = 2;
            this.BtnSearch.Text = "Tìm kiếm";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRefresh.Location = new System.Drawing.Point(889, 202);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(133, 35);
            this.BtnRefresh.TabIndex = 3;
            this.BtnRefresh.Text = "Xóa tìm kiếm";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelControl);
            this.panel1.Controls.Add(this.BtnSearch);
            this.panel1.Controls.Add(this.BtnRefresh);
            this.panel1.Controls.Add(this.BtnAdd);
            this.panel1.Controls.Add(this.BtnEdit);
            this.panel1.Controls.Add(this.BtnDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1022, 321);
            this.panel1.TabIndex = 7;
            // 
            // panelControl
            // 
            this.panelControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl.Controls.Add(this.txtID);
            this.panelControl.Controls.Add(this.boxID);
            this.panelControl.Controls.Add(this.boxPartial);
            this.panelControl.Controls.Add(this.txtPartial);
            this.panelControl.Controls.Add(this.boxAddress);
            this.panelControl.Controls.Add(this.txtAddress);
            this.panelControl.Controls.Add(this.boxPhone);
            this.panelControl.Controls.Add(this.txtPhone);
            this.panelControl.Controls.Add(this.boxCMND);
            this.panelControl.Controls.Add(this.txtCMND);
            this.panelControl.Controls.Add(this.dateInPicker);
            this.panelControl.Controls.Add(this.txtDateIn);
            this.panelControl.Controls.Add(this.cbBoxRole);
            this.panelControl.Controls.Add(this.txtRole);
            this.panelControl.Controls.Add(this.birthdayPicker);
            this.panelControl.Controls.Add(this.txtBirthday);
            this.panelControl.Controls.Add(this.rdbFemale);
            this.panelControl.Controls.Add(this.rdbMale);
            this.panelControl.Controls.Add(this.txtGender);
            this.panelControl.Controls.Add(this.txtName);
            this.panelControl.Controls.Add(this.boxName);
            this.panelControl.Controls.Add(this.txtFirstname);
            this.panelControl.Controls.Add(this.boxFirstname);
            this.panelControl.Controls.Add(this.kclSelected);
            this.panelControl.Location = new System.Drawing.Point(29, 3);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(832, 312);
            this.panelControl.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Location = new System.Drawing.Point(18, 75);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(86, 16);
            this.txtID.TabIndex = 33;
            this.txtID.Text = "Mã nhân viên";
            // 
            // boxID
            // 
            this.boxID.Location = new System.Drawing.Point(125, 72);
            this.boxID.Name = "boxID";
            this.boxID.Size = new System.Drawing.Size(244, 22);
            this.boxID.TabIndex = 1;
            // 
            // boxPartial
            // 
            this.boxPartial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boxPartial.Location = new System.Drawing.Point(551, 223);
            this.boxPartial.Name = "boxPartial";
            this.boxPartial.Size = new System.Drawing.Size(244, 22);
            this.boxPartial.TabIndex = 10;
            // 
            // txtPartial
            // 
            this.txtPartial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPartial.AutoSize = true;
            this.txtPartial.Location = new System.Drawing.Point(448, 226);
            this.txtPartial.Name = "txtPartial";
            this.txtPartial.Size = new System.Drawing.Size(57, 16);
            this.txtPartial.TabIndex = 31;
            this.txtPartial.Text = "Bộ phận";
            // 
            // boxAddress
            // 
            this.boxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boxAddress.Location = new System.Drawing.Point(551, 170);
            this.boxAddress.Name = "boxAddress";
            this.boxAddress.Size = new System.Drawing.Size(244, 22);
            this.boxAddress.TabIndex = 9;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.AutoSize = true;
            this.txtAddress.Location = new System.Drawing.Point(448, 173);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(47, 16);
            this.txtAddress.TabIndex = 29;
            this.txtAddress.Text = "Địa chỉ";
            // 
            // boxPhone
            // 
            this.boxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boxPhone.Location = new System.Drawing.Point(552, 122);
            this.boxPhone.Name = "boxPhone";
            this.boxPhone.Size = new System.Drawing.Size(243, 22);
            this.boxPhone.TabIndex = 8;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.AutoSize = true;
            this.txtPhone.Location = new System.Drawing.Point(448, 125);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(85, 16);
            this.txtPhone.TabIndex = 28;
            this.txtPhone.Text = "Số điện thoại";
            // 
            // boxCMND
            // 
            this.boxCMND.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boxCMND.Location = new System.Drawing.Point(551, 72);
            this.boxCMND.Name = "boxCMND";
            this.boxCMND.Size = new System.Drawing.Size(244, 22);
            this.boxCMND.TabIndex = 7;
            // 
            // txtCMND
            // 
            this.txtCMND.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCMND.AutoSize = true;
            this.txtCMND.Location = new System.Drawing.Point(448, 75);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(67, 16);
            this.txtCMND.TabIndex = 27;
            this.txtCMND.Text = "Số CMND";
            // 
            // dateInPicker
            // 
            this.dateInPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateInPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateInPicker.Location = new System.Drawing.Point(551, 18);
            this.dateInPicker.Name = "dateInPicker";
            this.dateInPicker.Size = new System.Drawing.Size(244, 22);
            this.dateInPicker.TabIndex = 6;
            // 
            // txtDateIn
            // 
            this.txtDateIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDateIn.AutoSize = true;
            this.txtDateIn.Location = new System.Drawing.Point(448, 23);
            this.txtDateIn.Name = "txtDateIn";
            this.txtDateIn.Size = new System.Drawing.Size(91, 16);
            this.txtDateIn.TabIndex = 19;
            this.txtDateIn.Text = "Ngày vào làm";
            // 
            // cbBoxRole
            // 
            this.cbBoxRole.FormattingEnabled = true;
            this.cbBoxRole.Items.AddRange(new object[] {
            "Điều dưỡng",
            "Bác sĩ",
            "Giám đốc"});
            this.cbBoxRole.Location = new System.Drawing.Point(552, 274);
            this.cbBoxRole.Name = "cbBoxRole";
            this.cbBoxRole.Size = new System.Drawing.Size(244, 24);
            this.cbBoxRole.TabIndex = 11;
            // 
            // txtRole
            // 
            this.txtRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRole.AutoSize = true;
            this.txtRole.Location = new System.Drawing.Point(447, 277);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(45, 16);
            this.txtRole.TabIndex = 18;
            this.txtRole.Text = "Vai trò";
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.birthdayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthdayPicker.Location = new System.Drawing.Point(125, 268);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.Size = new System.Drawing.Size(244, 22);
            this.birthdayPicker.TabIndex = 5;
            // 
            // txtBirthday
            // 
            this.txtBirthday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBirthday.AutoSize = true;
            this.txtBirthday.Location = new System.Drawing.Point(18, 273);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(67, 16);
            this.txtBirthday.TabIndex = 16;
            this.txtBirthday.Text = "Ngày sinh";
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(204, 219);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(45, 20);
            this.rdbFemale.TabIndex = 3;
            this.rdbFemale.Text = "Nữ";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Checked = true;
            this.rdbMale.Location = new System.Drawing.Point(125, 219);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(57, 20);
            this.rdbMale.TabIndex = 4;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Nam";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // txtGender
            // 
            this.txtGender.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtGender.AutoSize = true;
            this.txtGender.Location = new System.Drawing.Point(18, 221);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(54, 16);
            this.txtGender.TabIndex = 13;
            this.txtGender.Text = "Giới tính";
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(18, 175);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(31, 16);
            this.txtName.TabIndex = 4;
            this.txtName.Text = "Tên";
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(125, 172);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(244, 22);
            this.boxName.TabIndex = 3;
            // 
            // txtFirstname
            // 
            this.txtFirstname.AutoSize = true;
            this.txtFirstname.Location = new System.Drawing.Point(18, 125);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(81, 16);
            this.txtFirstname.TabIndex = 2;
            this.txtFirstname.Text = "Họ và tên lót";
            // 
            // boxFirstname
            // 
            this.boxFirstname.Location = new System.Drawing.Point(125, 122);
            this.boxFirstname.Name = "boxFirstname";
            this.boxFirstname.Size = new System.Drawing.Size(244, 22);
            this.boxFirstname.TabIndex = 2;
            // 
            // gridStaff
            // 
            this.gridStaff.AllowUserToAddRows = false;
            this.gridStaff.AllowUserToDeleteRows = false;
            this.gridStaff.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStaff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridStaff.Location = new System.Drawing.Point(0, 321);
            this.gridStaff.Name = "gridStaff";
            this.gridStaff.ReadOnly = true;
            this.gridStaff.RowHeadersVisible = false;
            this.gridStaff.RowHeadersWidth = 51;
            this.gridStaff.RowTemplate.Height = 24;
            this.gridStaff.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridStaff.Size = new System.Drawing.Size(1022, 298);
            this.gridStaff.TabIndex = 8;
            // 
            // kclSelected
            // 
            this.kclSelected.Location = new System.Drawing.Point(2, 2);
            this.kclSelected.Name = "kclSelected";
            this.kclSelected.Size = new System.Drawing.Size(401, 56);
            this.kclSelected.TabIndex = 0;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 637);
            this.Controls.Add(this.gridStaff);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelSideRight);
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            this.panel1.ResumeLayout(false);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStaff)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Panel panelSideRight;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView gridStaff;
        private System.Windows.Forms.Panel panelControl;
        private KCLSelected kclSelected;
        private System.Windows.Forms.Label txtFirstname;
        private System.Windows.Forms.TextBox boxFirstname;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.Label txtGender;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.Label txtBirthday;
        private System.Windows.Forms.DateTimePicker birthdayPicker;
        private System.Windows.Forms.ComboBox cbBoxRole;
        private System.Windows.Forms.Label txtRole;
        private System.Windows.Forms.DateTimePicker dateInPicker;
        private System.Windows.Forms.Label txtDateIn;
        private System.Windows.Forms.TextBox boxAddress;
        private System.Windows.Forms.Label txtAddress;
        private System.Windows.Forms.TextBox boxPhone;
        private System.Windows.Forms.Label txtPhone;
        private System.Windows.Forms.TextBox boxCMND;
        private System.Windows.Forms.Label txtCMND;
        private System.Windows.Forms.TextBox boxPartial;
        private System.Windows.Forms.Label txtPartial;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.TextBox boxID;
    }
}