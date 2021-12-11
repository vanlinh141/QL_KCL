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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gridDevice = new System.Windows.Forms.DataGridView();
            this.kclSelected = new QL_KCL.KCLSelected();
            this.txtID = new System.Windows.Forms.Label();
            this.boxID = new System.Windows.Forms.TextBox();
            this.boxName = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.Label();
            this.txtStaff = new System.Windows.Forms.Label();
            this.boxStaff = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.txtQuantity = new System.Windows.Forms.Label();
            this.boxQuantity = new System.Windows.Forms.NumericUpDown();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDevice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideRight
            // 
            this.panelSideRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSideRight.Location = new System.Drawing.Point(843, 0);
            this.panelSideRight.Name = "panelSideRight";
            this.panelSideRight.Size = new System.Drawing.Size(29, 444);
            this.panelSideRight.TabIndex = 0;
            // 
            // panelFooter
            // 
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 412);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(843, 32);
            this.panelFooter.TabIndex = 1;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.boxQuantity);
            this.panelHeader.Controls.Add(this.txtQuantity);
            this.panelHeader.Controls.Add(this.datePicker);
            this.panelHeader.Controls.Add(this.txtDate);
            this.panelHeader.Controls.Add(this.boxStaff);
            this.panelHeader.Controls.Add(this.txtStaff);
            this.panelHeader.Controls.Add(this.btnUpdate);
            this.panelHeader.Controls.Add(this.btnDelete);
            this.panelHeader.Controls.Add(this.txtName);
            this.panelHeader.Controls.Add(this.boxName);
            this.panelHeader.Controls.Add(this.boxID);
            this.panelHeader.Controls.Add(this.txtID);
            this.panelHeader.Controls.Add(this.kclSelected);
            this.panelHeader.Controls.Add(this.btnAdd);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(843, 191);
            this.panelHeader.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(739, 139);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 29);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa thiết bị";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.Location = new System.Drawing.Point(739, 85);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 29);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Chỉnh sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(739, 32);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 29);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm thiết bị";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.gridDevice.Size = new System.Drawing.Size(843, 221);
            this.gridDevice.TabIndex = 3;
            // 
            // kclSelected
            // 
            this.kclSelected.Location = new System.Drawing.Point(-14, 24);
            this.kclSelected.Name = "kclSelected";
            this.kclSelected.Size = new System.Drawing.Size(401, 56);
            this.kclSelected.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.AutoSize = true;
            this.txtID.Location = new System.Drawing.Point(2, 83);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(67, 16);
            this.txtID.TabIndex = 4;
            this.txtID.Text = "Mã thiết bị";
            // 
            // boxID
            // 
            this.boxID.Location = new System.Drawing.Point(108, 80);
            this.boxID.Name = "boxID";
            this.boxID.Size = new System.Drawing.Size(242, 22);
            this.boxID.TabIndex = 5;
            // 
            // boxName
            // 
            this.boxName.Location = new System.Drawing.Point(108, 125);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(242, 22);
            this.boxName.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(2, 128);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(72, 16);
            this.txtName.TabIndex = 7;
            this.txtName.Text = "Tên thiết bị";
            // 
            // txtStaff
            // 
            this.txtStaff.AutoSize = true;
            this.txtStaff.Location = new System.Drawing.Point(373, 83);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.Size = new System.Drawing.Size(86, 16);
            this.txtStaff.TabIndex = 8;
            this.txtStaff.Text = "Mã nhân viên";
            // 
            // boxStaff
            // 
            this.boxStaff.Location = new System.Drawing.Point(479, 80);
            this.boxStaff.Name = "boxStaff";
            this.boxStaff.Size = new System.Drawing.Size(242, 22);
            this.boxStaff.TabIndex = 9;
            // 
            // txtDate
            // 
            this.txtDate.AutoSize = true;
            this.txtDate.Location = new System.Drawing.Point(373, 128);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(86, 16);
            this.txtDate.TabIndex = 10;
            this.txtDate.Text = "Mã nhân viên";
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(479, 122);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(242, 22);
            this.datePicker.TabIndex = 11;
            this.datePicker.Value = new System.DateTime(2021, 12, 11, 13, 51, 33, 0);
            // 
            // txtQuantity
            // 
            this.txtQuantity.AutoSize = true;
            this.txtQuantity.Location = new System.Drawing.Point(373, 45);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(60, 16);
            this.txtQuantity.TabIndex = 12;
            this.txtQuantity.Text = "Số lượng";
            // 
            // boxQuantity
            // 
            this.boxQuantity.Location = new System.Drawing.Point(479, 43);
            this.boxQuantity.Name = "boxQuantity";
            this.boxQuantity.Size = new System.Drawing.Size(242, 22);
            this.boxQuantity.TabIndex = 14;
            // 
            // DeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 444);
            this.Controls.Add(this.gridDevice);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelSideRight);
            this.Name = "DeviceForm";
            this.Text = "Quản lý thiết bị";
            this.Load += new System.EventHandler(this.DeviceForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDevice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideRight;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.DataGridView gridDevice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
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