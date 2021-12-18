namespace QL_KCL
{
    partial class TestForm
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
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.panelControl = new System.Windows.Forms.Panel();
            this.boxResult = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.Label();
            this.boxNote = new System.Windows.Forms.TextBox();
            this.txtNote = new System.Windows.Forms.Label();
            this.txtNextTest = new System.Windows.Forms.Label();
            this.dateNextTestPicker = new System.Windows.Forms.DateTimePicker();
            this.boxCT = new System.Windows.Forms.TextBox();
            this.txtCT = new System.Windows.Forms.Label();
            this.dateResultPicker = new System.Windows.Forms.DateTimePicker();
            this.txtDateResult = new System.Windows.Forms.Label();
            this.dateTestPicker = new System.Windows.Forms.DateTimePicker();
            this.txtDateTest = new System.Windows.Forms.Label();
            this.cbBoxTypeTest = new System.Windows.Forms.ComboBox();
            this.txtTypeTest = new System.Windows.Forms.Label();
            this.boxVictimID = new System.Windows.Forms.TextBox();
            this.boxStaffID = new System.Windows.Forms.TextBox();
            this.txtVictimID = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.Label();
            this.boxID = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.Label();
            this.gridTest = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            this.panelControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTest)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideRight
            // 
            this.panelSideRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSideRight.Location = new System.Drawing.Point(1189, 0);
            this.panelSideRight.Name = "panelSideRight";
            this.panelSideRight.Size = new System.Drawing.Size(20, 577);
            this.panelSideRight.TabIndex = 0;
            // 
            // panelFooter
            // 
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 558);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1189, 19);
            this.panelFooter.TabIndex = 1;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.BtnClear);
            this.panelHeader.Controls.Add(this.BtnSearch);
            this.panelHeader.Controls.Add(this.BtnAdd);
            this.panelHeader.Controls.Add(this.BtnEdit);
            this.panelHeader.Controls.Add(this.BtnDelete);
            this.panelHeader.Controls.Add(this.panelControl);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1189, 302);
            this.panelHeader.TabIndex = 2;
            // 
            // BtnClear
            // 
            this.BtnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnClear.Location = new System.Drawing.Point(1038, 189);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(151, 35);
            this.BtnClear.TabIndex = 4;
            this.BtnClear.Text = "Xóa tìm kiếm";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearch.Location = new System.Drawing.Point(1038, 134);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(151, 35);
            this.BtnSearch.TabIndex = 3;
            this.BtnSearch.Text = "Tìm theo bệnh nhân";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.Location = new System.Drawing.Point(1038, 26);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(151, 35);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Thêm mới";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.Location = new System.Drawing.Point(1038, 82);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(151, 35);
            this.BtnEdit.TabIndex = 1;
            this.BtnEdit.Text = "Chỉnh sửa";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Location = new System.Drawing.Point(1038, 243);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(151, 35);
            this.BtnDelete.TabIndex = 0;
            this.BtnDelete.Text = "Xóa kết quả";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // panelControl
            // 
            this.panelControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelControl.Controls.Add(this.boxResult);
            this.panelControl.Controls.Add(this.txtResult);
            this.panelControl.Controls.Add(this.boxNote);
            this.panelControl.Controls.Add(this.txtNote);
            this.panelControl.Controls.Add(this.txtNextTest);
            this.panelControl.Controls.Add(this.dateNextTestPicker);
            this.panelControl.Controls.Add(this.boxCT);
            this.panelControl.Controls.Add(this.txtCT);
            this.panelControl.Controls.Add(this.dateResultPicker);
            this.panelControl.Controls.Add(this.txtDateResult);
            this.panelControl.Controls.Add(this.dateTestPicker);
            this.panelControl.Controls.Add(this.txtDateTest);
            this.panelControl.Controls.Add(this.cbBoxTypeTest);
            this.panelControl.Controls.Add(this.txtTypeTest);
            this.panelControl.Controls.Add(this.boxVictimID);
            this.panelControl.Controls.Add(this.boxStaffID);
            this.panelControl.Controls.Add(this.txtVictimID);
            this.panelControl.Controls.Add(this.txtStaffID);
            this.panelControl.Controls.Add(this.boxID);
            this.panelControl.Controls.Add(this.txtID);
            this.panelControl.Location = new System.Drawing.Point(3, 3);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1001, 299);
            this.panelControl.TabIndex = 0;
            // 
            // boxResult
            // 
            this.boxResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.boxResult.Location = new System.Drawing.Point(690, 199);
            this.boxResult.Name = "boxResult";
            this.boxResult.Size = new System.Drawing.Size(247, 22);
            this.boxResult.TabIndex = 8;
            // 
            // txtResult
            // 
            this.txtResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtResult.AutoSize = true;
            this.txtResult.Location = new System.Drawing.Point(494, 202);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(119, 16);
            this.txtResult.TabIndex = 20;
            this.txtResult.Text = "Kết quả xét nghiệm";
            // 
            // boxNote
            // 
            this.boxNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.boxNote.Location = new System.Drawing.Point(690, 256);
            this.boxNote.Name = "boxNote";
            this.boxNote.Size = new System.Drawing.Size(247, 22);
            this.boxNote.TabIndex = 9;
            // 
            // txtNote
            // 
            this.txtNote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNote.AutoSize = true;
            this.txtNote.Location = new System.Drawing.Point(494, 259);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(51, 16);
            this.txtNote.TabIndex = 22;
            this.txtNote.Text = "Ghi chú";
            // 
            // txtNextTest
            // 
            this.txtNextTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtNextTest.AutoSize = true;
            this.txtNextTest.Location = new System.Drawing.Point(494, 139);
            this.txtNextTest.Name = "txtNextTest";
            this.txtNextTest.Size = new System.Drawing.Size(161, 16);
            this.txtNextTest.TabIndex = 18;
            this.txtNextTest.Text = "Ngày xét nghiệm tiếp theo";
            // 
            // dateNextTestPicker
            // 
            this.dateNextTestPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dateNextTestPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateNextTestPicker.Location = new System.Drawing.Point(690, 136);
            this.dateNextTestPicker.Name = "dateNextTestPicker";
            this.dateNextTestPicker.Size = new System.Drawing.Size(247, 22);
            this.dateNextTestPicker.TabIndex = 7;
            // 
            // boxCT
            // 
            this.boxCT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.boxCT.Location = new System.Drawing.Point(690, 75);
            this.boxCT.Name = "boxCT";
            this.boxCT.Size = new System.Drawing.Size(247, 22);
            this.boxCT.TabIndex = 6;
            // 
            // txtCT
            // 
            this.txtCT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtCT.AutoSize = true;
            this.txtCT.Location = new System.Drawing.Point(494, 78);
            this.txtCT.Name = "txtCT";
            this.txtCT.Size = new System.Drawing.Size(65, 16);
            this.txtCT.TabIndex = 16;
            this.txtCT.Text = "Chỉ số CT";
            // 
            // dateResultPicker
            // 
            this.dateResultPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dateResultPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateResultPicker.Location = new System.Drawing.Point(690, 20);
            this.dateResultPicker.Name = "dateResultPicker";
            this.dateResultPicker.Size = new System.Drawing.Size(247, 22);
            this.dateResultPicker.TabIndex = 5;
            // 
            // txtDateResult
            // 
            this.txtDateResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDateResult.AutoSize = true;
            this.txtDateResult.Location = new System.Drawing.Point(494, 23);
            this.txtDateResult.Name = "txtDateResult";
            this.txtDateResult.Size = new System.Drawing.Size(119, 16);
            this.txtDateResult.TabIndex = 14;
            this.txtDateResult.Text = "Ngày nhận kết quả";
            // 
            // dateTestPicker
            // 
            this.dateTestPicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dateTestPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTestPicker.Location = new System.Drawing.Point(216, 256);
            this.dateTestPicker.Name = "dateTestPicker";
            this.dateTestPicker.Size = new System.Drawing.Size(247, 22);
            this.dateTestPicker.TabIndex = 4;
            // 
            // txtDateTest
            // 
            this.txtDateTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDateTest.AutoSize = true;
            this.txtDateTest.Location = new System.Drawing.Point(78, 259);
            this.txtDateTest.Name = "txtDateTest";
            this.txtDateTest.Size = new System.Drawing.Size(107, 16);
            this.txtDateTest.TabIndex = 13;
            this.txtDateTest.Text = "Ngày xét nghiệm";
            // 
            // cbBoxTypeTest
            // 
            this.cbBoxTypeTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbBoxTypeTest.FormattingEnabled = true;
            this.cbBoxTypeTest.Items.AddRange(new object[] {
            "Xét nghiệm nhanh kháng nguyên",
            "Xét nghiệm RT-PCR",
            "Xét nghiệm nhanh kháng thể (ELISA)",
            "Xét nghiệm mẫu gộp (POOLED TEST)"});
            this.cbBoxTypeTest.Location = new System.Drawing.Point(216, 199);
            this.cbBoxTypeTest.Name = "cbBoxTypeTest";
            this.cbBoxTypeTest.Size = new System.Drawing.Size(247, 24);
            this.cbBoxTypeTest.TabIndex = 3;
            // 
            // txtTypeTest
            // 
            this.txtTypeTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtTypeTest.AutoSize = true;
            this.txtTypeTest.Location = new System.Drawing.Point(78, 202);
            this.txtTypeTest.Name = "txtTypeTest";
            this.txtTypeTest.Size = new System.Drawing.Size(100, 16);
            this.txtTypeTest.TabIndex = 11;
            this.txtTypeTest.Text = "Loại xét nghiệm";
            // 
            // boxVictimID
            // 
            this.boxVictimID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.boxVictimID.Location = new System.Drawing.Point(216, 136);
            this.boxVictimID.Name = "boxVictimID";
            this.boxVictimID.Size = new System.Drawing.Size(247, 22);
            this.boxVictimID.TabIndex = 2;
            // 
            // boxStaffID
            // 
            this.boxStaffID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.boxStaffID.Location = new System.Drawing.Point(216, 75);
            this.boxStaffID.Name = "boxStaffID";
            this.boxStaffID.ReadOnly = true;
            this.boxStaffID.Size = new System.Drawing.Size(247, 22);
            this.boxStaffID.TabIndex = 1;
            // 
            // txtVictimID
            // 
            this.txtVictimID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtVictimID.AutoSize = true;
            this.txtVictimID.Location = new System.Drawing.Point(78, 139);
            this.txtVictimID.Name = "txtVictimID";
            this.txtVictimID.Size = new System.Drawing.Size(91, 16);
            this.txtVictimID.TabIndex = 8;
            this.txtVictimID.Text = "Mã bệnh nhân";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtStaffID.AutoSize = true;
            this.txtStaffID.Location = new System.Drawing.Point(78, 78);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.Size = new System.Drawing.Size(86, 16);
            this.txtStaffID.TabIndex = 7;
            this.txtStaffID.Text = "Mã nhân viên";
            // 
            // boxID
            // 
            this.boxID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.boxID.Location = new System.Drawing.Point(216, 20);
            this.boxID.Name = "boxID";
            this.boxID.Size = new System.Drawing.Size(247, 22);
            this.boxID.TabIndex = 0;
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtID.AutoSize = true;
            this.txtID.Location = new System.Drawing.Point(78, 23);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(93, 16);
            this.txtID.TabIndex = 5;
            this.txtID.Text = "Mã xét nghiệm";
            // 
            // gridTest
            // 
            this.gridTest.AllowUserToAddRows = false;
            this.gridTest.AllowUserToDeleteRows = false;
            this.gridTest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTest.Location = new System.Drawing.Point(0, 302);
            this.gridTest.Name = "gridTest";
            this.gridTest.ReadOnly = true;
            this.gridTest.RowHeadersVisible = false;
            this.gridTest.RowHeadersWidth = 51;
            this.gridTest.RowTemplate.Height = 24;
            this.gridTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridTest.Size = new System.Drawing.Size(1189, 256);
            this.gridTest.TabIndex = 3;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 577);
            this.Controls.Add(this.gridTest);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelSideRight);
            this.Name = "TestForm";
            this.Load += new System.EventHandler(this.TestForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideRight;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.DataGridView gridTest;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.TextBox boxID;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.TextBox boxVictimID;
        private System.Windows.Forms.TextBox boxStaffID;
        private System.Windows.Forms.Label txtVictimID;
        private System.Windows.Forms.Label txtStaffID;
        private System.Windows.Forms.ComboBox cbBoxTypeTest;
        private System.Windows.Forms.Label txtTypeTest;
        private System.Windows.Forms.Label txtDateTest;
        private System.Windows.Forms.DateTimePicker dateTestPicker;
        private System.Windows.Forms.Label txtCT;
        private System.Windows.Forms.DateTimePicker dateResultPicker;
        private System.Windows.Forms.Label txtDateResult;
        private System.Windows.Forms.TextBox boxCT;
        private System.Windows.Forms.Label txtNextTest;
        private System.Windows.Forms.DateTimePicker dateNextTestPicker;
        private System.Windows.Forms.TextBox boxResult;
        private System.Windows.Forms.Label txtResult;
        private System.Windows.Forms.TextBox boxNote;
        private System.Windows.Forms.Label txtNote;
    }
}