namespace QL_KCL
{
    partial class VictimForm
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
            this.panelSideRight = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.cBoxBed = new System.Windows.Forms.CheckBox();
            this.dateoutPicker = new System.Windows.Forms.DateTimePicker();
            this.txtCheckOut = new System.Windows.Forms.Label();
            this.dateinPicker = new System.Windows.Forms.DateTimePicker();
            this.txtCheckIn = new System.Windows.Forms.Label();
            this.boxAddress = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.Label();
            this.boxPhone = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.Label();
            this.bedSelected = new QL_KCL.BedSelected();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.txtID = new System.Windows.Forms.Label();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.txtGender = new System.Windows.Forms.Label();
            this.boxID = new System.Windows.Forms.TextBox();
            this.boxCMND = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.Label();
            this.boxName = new System.Windows.Forms.TextBox();
            this.birthdayPicker = new System.Windows.Forms.DateTimePicker();
            this.txtBirthday = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.Label();
            this.boxFirstName = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.Label();
            this.kclSelected = new QL_KCL.KCLSelected();
            this.gridVictim = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            this.panelInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVictim)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideRight
            // 
            this.panelSideRight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelSideRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSideRight.Location = new System.Drawing.Point(1060, 0);
            this.panelSideRight.Name = "panelSideRight";
            this.panelSideRight.Size = new System.Drawing.Size(29, 609);
            this.panelSideRight.TabIndex = 0;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 585);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1060, 24);
            this.panelFooter.TabIndex = 1;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelHeader.Controls.Add(this.BtnRefresh);
            this.panelHeader.Controls.Add(this.BtnSearch);
            this.panelHeader.Controls.Add(this.BtnEdit);
            this.panelHeader.Controls.Add(this.BtnAdd);
            this.panelHeader.Controls.Add(this.BtnDelete);
            this.panelHeader.Controls.Add(this.panelInfo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1060, 368);
            this.panelHeader.TabIndex = 2;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresh.Location = new System.Drawing.Point(893, 247);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(167, 35);
            this.BtnRefresh.TabIndex = 22;
            this.BtnRefresh.Text = "Xóa tìm kiếm";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearch.Location = new System.Drawing.Point(893, 178);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(167, 35);
            this.BtnSearch.TabIndex = 15;
            this.BtnSearch.Text = "Tìm kiếm bệnh nhân";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.Location = new System.Drawing.Point(893, 113);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(167, 35);
            this.BtnEdit.TabIndex = 14;
            this.BtnEdit.Text = "Chỉnh sửa thông tin";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.Location = new System.Drawing.Point(893, 51);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(167, 35);
            this.BtnAdd.TabIndex = 13;
            this.BtnAdd.Text = "Thêm bệnh nhân";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.Location = new System.Drawing.Point(893, 311);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(167, 35);
            this.BtnDelete.TabIndex = 16;
            this.BtnDelete.Text = "Xóa bệnh nhân";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // panelInfo
            // 
            this.panelInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelInfo.Controls.Add(this.cBoxBed);
            this.panelInfo.Controls.Add(this.dateoutPicker);
            this.panelInfo.Controls.Add(this.txtCheckOut);
            this.panelInfo.Controls.Add(this.dateinPicker);
            this.panelInfo.Controls.Add(this.txtCheckIn);
            this.panelInfo.Controls.Add(this.boxAddress);
            this.panelInfo.Controls.Add(this.txtAddress);
            this.panelInfo.Controls.Add(this.boxPhone);
            this.panelInfo.Controls.Add(this.txtPhone);
            this.panelInfo.Controls.Add(this.bedSelected);
            this.panelInfo.Controls.Add(this.rdbFemale);
            this.panelInfo.Controls.Add(this.txtID);
            this.panelInfo.Controls.Add(this.rdbMale);
            this.panelInfo.Controls.Add(this.txtGender);
            this.panelInfo.Controls.Add(this.boxID);
            this.panelInfo.Controls.Add(this.boxCMND);
            this.panelInfo.Controls.Add(this.txtName);
            this.panelInfo.Controls.Add(this.boxName);
            this.panelInfo.Controls.Add(this.birthdayPicker);
            this.panelInfo.Controls.Add(this.txtBirthday);
            this.panelInfo.Controls.Add(this.txtFirstName);
            this.panelInfo.Controls.Add(this.boxFirstName);
            this.panelInfo.Controls.Add(this.txtCMND);
            this.panelInfo.Controls.Add(this.kclSelected);
            this.panelInfo.Location = new System.Drawing.Point(38, 35);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(839, 327);
            this.panelInfo.TabIndex = 21;
            // 
            // cBoxBed
            // 
            this.cBoxBed.AutoSize = true;
            this.cBoxBed.Location = new System.Drawing.Point(125, 286);
            this.cBoxBed.Name = "cBoxBed";
            this.cBoxBed.Size = new System.Drawing.Size(237, 20);
            this.cBoxBed.TabIndex = 28;
            this.cBoxBed.Text = "Giữ nguyên giường khi sửa thông tin";
            this.cBoxBed.UseVisualStyleBackColor = true;
            // 
            // dateoutPicker
            // 
            this.dateoutPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateoutPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateoutPicker.Location = new System.Drawing.Point(524, 252);
            this.dateoutPicker.Name = "dateoutPicker";
            this.dateoutPicker.Size = new System.Drawing.Size(243, 22);
            this.dateoutPicker.TabIndex = 12;
            // 
            // txtCheckOut
            // 
            this.txtCheckOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCheckOut.AutoSize = true;
            this.txtCheckOut.Location = new System.Drawing.Point(405, 257);
            this.txtCheckOut.Name = "txtCheckOut";
            this.txtCheckOut.Size = new System.Drawing.Size(101, 16);
            this.txtCheckOut.TabIndex = 27;
            this.txtCheckOut.Text = "Ngày ra dự kiến";
            // 
            // dateinPicker
            // 
            this.dateinPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateinPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateinPicker.Location = new System.Drawing.Point(524, 205);
            this.dateinPicker.Name = "dateinPicker";
            this.dateinPicker.Size = new System.Drawing.Size(243, 22);
            this.dateinPicker.TabIndex = 11;
            // 
            // txtCheckIn
            // 
            this.txtCheckIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCheckIn.AutoSize = true;
            this.txtCheckIn.Location = new System.Drawing.Point(405, 207);
            this.txtCheckIn.Name = "txtCheckIn";
            this.txtCheckIn.Size = new System.Drawing.Size(66, 16);
            this.txtCheckIn.TabIndex = 25;
            this.txtCheckIn.Text = "Ngày vào";
            // 
            // boxAddress
            // 
            this.boxAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boxAddress.Location = new System.Drawing.Point(524, 159);
            this.boxAddress.Name = "boxAddress";
            this.boxAddress.Size = new System.Drawing.Size(243, 22);
            this.boxAddress.TabIndex = 10;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.AutoSize = true;
            this.txtAddress.Location = new System.Drawing.Point(405, 162);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(47, 16);
            this.txtAddress.TabIndex = 23;
            this.txtAddress.Text = "Địa chỉ";
            // 
            // boxPhone
            // 
            this.boxPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boxPhone.Location = new System.Drawing.Point(524, 108);
            this.boxPhone.Name = "boxPhone";
            this.boxPhone.Size = new System.Drawing.Size(243, 22);
            this.boxPhone.TabIndex = 9;
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhone.AutoSize = true;
            this.txtPhone.Location = new System.Drawing.Point(405, 114);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(85, 16);
            this.txtPhone.TabIndex = 21;
            this.txtPhone.Text = "Số điện thoại";
            // 
            // bedSelected
            // 
            this.bedSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bedSelected.Location = new System.Drawing.Point(3, 238);
            this.bedSelected.Name = "bedSelected";
            this.bedSelected.Size = new System.Drawing.Size(401, 56);
            this.bedSelected.TabIndex = 6;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(227, 206);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(45, 20);
            this.rdbFemale.TabIndex = 5;
            this.rdbFemale.Text = "Nữ";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Location = new System.Drawing.Point(18, 67);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(91, 16);
            this.txtID.TabIndex = 18;
            this.txtID.Text = "Mã bệnh nhân";
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Checked = true;
            this.rdbMale.Location = new System.Drawing.Point(125, 206);
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
            this.txtGender.Location = new System.Drawing.Point(18, 208);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(54, 16);
            this.txtGender.TabIndex = 12;
            this.txtGender.Text = "Giới tính";
            // 
            // boxID
            // 
            this.boxID.Location = new System.Drawing.Point(125, 64);
            this.boxID.Name = "boxID";
            this.boxID.Size = new System.Drawing.Size(243, 22);
            this.boxID.TabIndex = 1;
            // 
            // boxCMND
            // 
            this.boxCMND.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.boxCMND.Location = new System.Drawing.Point(524, 64);
            this.boxCMND.Name = "boxCMND";
            this.boxCMND.Size = new System.Drawing.Size(243, 22);
            this.boxCMND.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(18, 162);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(31, 16);
            this.txtName.TabIndex = 8;
            this.txtName.Text = "Tên";
            // 
            // boxName
            // 
            this.boxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.boxName.Location = new System.Drawing.Point(125, 159);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(243, 22);
            this.boxName.TabIndex = 3;
            // 
            // birthdayPicker
            // 
            this.birthdayPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.birthdayPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthdayPicker.Location = new System.Drawing.Point(524, 14);
            this.birthdayPicker.Name = "birthdayPicker";
            this.birthdayPicker.Size = new System.Drawing.Size(243, 22);
            this.birthdayPicker.TabIndex = 7;
            // 
            // txtBirthday
            // 
            this.txtBirthday.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBirthday.AutoSize = true;
            this.txtBirthday.Location = new System.Drawing.Point(405, 19);
            this.txtBirthday.Name = "txtBirthday";
            this.txtBirthday.Size = new System.Drawing.Size(67, 16);
            this.txtBirthday.TabIndex = 15;
            this.txtBirthday.Text = "Ngày sinh";
            // 
            // txtFirstName
            // 
            this.txtFirstName.AutoSize = true;
            this.txtFirstName.Location = new System.Drawing.Point(18, 114);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(81, 16);
            this.txtFirstName.TabIndex = 6;
            this.txtFirstName.Text = "Họ và tên lót";
            // 
            // boxFirstName
            // 
            this.boxFirstName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.boxFirstName.Location = new System.Drawing.Point(125, 111);
            this.boxFirstName.Name = "boxFirstName";
            this.boxFirstName.Size = new System.Drawing.Size(243, 22);
            this.boxFirstName.TabIndex = 2;
            // 
            // txtCMND
            // 
            this.txtCMND.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCMND.AutoSize = true;
            this.txtCMND.Location = new System.Drawing.Point(405, 67);
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(67, 16);
            this.txtCMND.TabIndex = 17;
            this.txtCMND.Text = "Số CMND";
            // 
            // kclSelected
            // 
            this.kclSelected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.kclSelected.Location = new System.Drawing.Point(3, 0);
            this.kclSelected.Name = "kclSelected";
            this.kclSelected.Size = new System.Drawing.Size(401, 58);
            this.kclSelected.TabIndex = 0;
            // 
            // gridVictim
            // 
            this.gridVictim.AllowUserToAddRows = false;
            this.gridVictim.AllowUserToDeleteRows = false;
            this.gridVictim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridVictim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVictim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridVictim.Location = new System.Drawing.Point(0, 368);
            this.gridVictim.Name = "gridVictim";
            this.gridVictim.ReadOnly = true;
            this.gridVictim.RowHeadersVisible = false;
            this.gridVictim.RowHeadersWidth = 51;
            this.gridVictim.RowTemplate.Height = 24;
            this.gridVictim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridVictim.Size = new System.Drawing.Size(1060, 217);
            this.gridVictim.TabIndex = 17;
            // 
            // VictimForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 609);
            this.Controls.Add(this.gridVictim);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelSideRight);
            this.Name = "VictimForm";
            this.Text = "VictimForm";
            this.Load += new System.EventHandler(this.VictimForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridVictim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideRight;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.DataGridView gridVictim;
        private KCLSelected kclSelected;
        private BedSelected bedSelected;
        private System.Windows.Forms.TextBox boxFirstName;
        private System.Windows.Forms.Label txtFirstName;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.Label txtGender;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.TextBox boxID;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.TextBox boxCMND;
        private System.Windows.Forms.DateTimePicker birthdayPicker;
        private System.Windows.Forms.Label txtBirthday;
        private System.Windows.Forms.Label txtCMND;
        private System.Windows.Forms.DateTimePicker dateoutPicker;
        private System.Windows.Forms.Label txtCheckOut;
        private System.Windows.Forms.DateTimePicker dateinPicker;
        private System.Windows.Forms.Label txtCheckIn;
        private System.Windows.Forms.TextBox boxAddress;
        private System.Windows.Forms.Label txtAddress;
        private System.Windows.Forms.TextBox boxPhone;
        private System.Windows.Forms.Label txtPhone;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.CheckBox cBoxBed;
    }
}