namespace QL_KCL
{
    partial class DeviceForm
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
            this.kclSelected = new QL_KCL.KCLSelected();
            this.boxQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtQuantity = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.txtDate = new System.Windows.Forms.Label();
            this.boxStaff = new System.Windows.Forms.TextBox();
            this.txtStaff = new System.Windows.Forms.Label();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.Label();
            this.boxName = new System.Windows.Forms.TextBox();
            this.boxID = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.Label();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.gridDevice = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDevice)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideRight
            // 
            this.panelSideRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSideRight.Location = new System.Drawing.Point(988, 0);
            this.panelSideRight.Name = "panelSideRight";
            this.panelSideRight.Size = new System.Drawing.Size(29, 412);
            this.panelSideRight.TabIndex = 0;
            // 
            // panelFooter
            // 
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 412);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1017, 32);
            this.panelFooter.TabIndex = 1;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.kclSelected);
            this.panelHeader.Controls.Add(this.boxQuantity);
            this.panelHeader.Controls.Add(this.txtQuantity);
            this.panelHeader.Controls.Add(this.datePicker);
            this.panelHeader.Controls.Add(this.txtDate);
            this.panelHeader.Controls.Add(this.boxStaff);
            this.panelHeader.Controls.Add(this.txtStaff);
            this.panelHeader.Controls.Add(this.BtnUpdate);
            this.panelHeader.Controls.Add(this.BtnDelete);
            this.panelHeader.Controls.Add(this.txtName);
            this.panelHeader.Controls.Add(this.boxName);
            this.panelHeader.Controls.Add(this.boxID);
            this.panelHeader.Controls.Add(this.txtID);
            this.panelHeader.Controls.Add(this.BtnAdd);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(988, 191);
            this.panelHeader.TabIndex = 2;
            // 
            // kclSelected
            // 
            this.kclSelected.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.kclSelected.AutoSize = true;
            this.kclSelected.Location = new System.Drawing.Point(55, 21);
            this.kclSelected.Name = "kclSelected";
            this.kclSelected.Size = new System.Drawing.Size(370, 43);
            this.kclSelected.TabIndex = 10;
            // 
            // boxQuantity
            // 
            this.boxQuantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.boxQuantity.Location = new System.Drawing.Point(552, 43);
            this.boxQuantity.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.boxQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.boxQuantity.Name = "boxQuantity";
            this.boxQuantity.Size = new System.Drawing.Size(242, 22);
            this.boxQuantity.TabIndex = 14;
            this.boxQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtQuantity.AutoSize = true;
            this.txtQuantity.Location = new System.Drawing.Point(446, 45);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(60, 16);
            this.txtQuantity.TabIndex = 12;
            this.txtQuantity.Text = "Số lượng";
            // 
            // datePicker
            // 
            this.datePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(552, 122);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(242, 22);
            this.datePicker.TabIndex = 11;
            this.datePicker.Value = new System.DateTime(2021, 12, 11, 13, 51, 33, 0);
            // 
            // txtDate
            // 
            this.txtDate.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDate.AutoSize = true;
            this.txtDate.Location = new System.Drawing.Point(446, 128);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(73, 16);
            this.txtDate.TabIndex = 10;
            this.txtDate.Text = "Ngày nhập";
            // 
            // boxStaff
            // 
            this.boxStaff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.boxStaff.Location = new System.Drawing.Point(552, 80);
            this.boxStaff.Name = "boxStaff";
            this.boxStaff.ReadOnly = true;
            this.boxStaff.Size = new System.Drawing.Size(242, 22);
            this.boxStaff.TabIndex = 9;
            // 
            // txtStaff
            // 
            this.txtStaff.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtStaff.AutoSize = true;
            this.txtStaff.Location = new System.Drawing.Point(446, 83);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.Size = new System.Drawing.Size(86, 16);
            this.txtStaff.TabIndex = 8;
            this.txtStaff.Text = "Mã nhân viên";
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdate.Location = new System.Drawing.Point(884, 85);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(103, 35);
            this.BtnUpdate.TabIndex = 1;
            this.BtnUpdate.Text = "Chỉnh sửa";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.Location = new System.Drawing.Point(884, 139);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(103, 35);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Xóa thiết bị";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(75, 128);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(72, 16);
            this.txtName.TabIndex = 7;
            this.txtName.Text = "Tên thiết bị";
            // 
            // boxName
            // 
            this.boxName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.boxName.Location = new System.Drawing.Point(181, 125);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(242, 22);
            this.boxName.TabIndex = 6;
            // 
            // boxID
            // 
            this.boxID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.boxID.Location = new System.Drawing.Point(181, 80);
            this.boxID.Name = "boxID";
            this.boxID.Size = new System.Drawing.Size(242, 22);
            this.boxID.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtID.AutoSize = true;
            this.txtID.Location = new System.Drawing.Point(75, 83);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(67, 16);
            this.txtID.TabIndex = 4;
            this.txtID.Text = "Mã thiết bị";
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.Location = new System.Drawing.Point(884, 32);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(103, 35);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "Thêm thiết bị";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // gridDevice
            // 
            this.gridDevice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridDevice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDevice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridDevice.Location = new System.Drawing.Point(0, 191);
            this.gridDevice.Name = "gridDevice";
            this.gridDevice.RowHeadersVisible = false;
            this.gridDevice.RowHeadersWidth = 51;
            this.gridDevice.RowTemplate.Height = 24;
            this.gridDevice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDevice.Size = new System.Drawing.Size(988, 221);
            this.gridDevice.TabIndex = 3;
            // 
            // DeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 444);
            this.Controls.Add(this.gridDevice);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSideRight);
            this.Controls.Add(this.panelFooter);
            this.Name = "DeviceForm";
            this.Text = "Quản lý thiết bị";
            this.Load += new System.EventHandler(this.DeviceForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDevice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideRight;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.DataGridView gridDevice;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private KCLSelected kclSelected;
        private System.Windows.Forms.TextBox boxID;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.TextBox boxStaff;
        private System.Windows.Forms.Label txtStaff;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label txtDate;
        private System.Windows.Forms.Label txtQuantity;
        private System.Windows.Forms.NumericUpDown boxQuantity;
    }
}