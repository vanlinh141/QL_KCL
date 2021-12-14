namespace QL_KCL
{
    partial class HealthForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.gridID = new System.Windows.Forms.DataGridView();
            this.boxID = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.Label();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.boxHealth = new System.Windows.Forms.TextBox();
            this.txtHealth = new System.Windows.Forms.Label();
            this.cbBoxType = new System.Windows.Forms.ComboBox();
            this.txtType = new System.Windows.Forms.Label();
            this.gridHealth = new System.Windows.Forms.DataGridView();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHealth)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideRight
            // 
            this.panelSideRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSideRight.Location = new System.Drawing.Point(907, 0);
            this.panelSideRight.Name = "panelSideRight";
            this.panelSideRight.Size = new System.Drawing.Size(33, 583);
            this.panelSideRight.TabIndex = 15;
            // 
            // panelFooter
            // 
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 551);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(907, 32);
            this.panelFooter.TabIndex = 16;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.gridID);
            this.panelHeader.Controls.Add(this.boxID);
            this.panelHeader.Controls.Add(this.txtID);
            this.panelHeader.Controls.Add(this.BtnRefresh);
            this.panelHeader.Controls.Add(this.BtnSearch);
            this.panelHeader.Controls.Add(this.BtnAdd);
            this.panelHeader.Controls.Add(this.BtnEdit);
            this.panelHeader.Controls.Add(this.BtnDelete);
            this.panelHeader.Controls.Add(this.boxHealth);
            this.panelHeader.Controls.Add(this.txtHealth);
            this.panelHeader.Controls.Add(this.cbBoxType);
            this.panelHeader.Controls.Add(this.txtType);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(907, 240);
            this.panelHeader.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(619, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Danh sách bệnh nhân chưa nhập thông tin";
            // 
            // gridID
            // 
            this.gridID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gridID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridID.Location = new System.Drawing.Point(605, 74);
            this.gridID.Name = "gridID";
            this.gridID.ReadOnly = true;
            this.gridID.RowHeadersVisible = false;
            this.gridID.RowHeadersWidth = 51;
            this.gridID.RowTemplate.Height = 24;
            this.gridID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridID.Size = new System.Drawing.Size(302, 150);
            this.gridID.TabIndex = 10;
            // 
            // boxID
            // 
            this.boxID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.boxID.Location = new System.Drawing.Point(153, 44);
            this.boxID.Name = "boxID";
            this.boxID.Size = new System.Drawing.Size(255, 22);
            this.boxID.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtID.AutoSize = true;
            this.txtID.Location = new System.Drawing.Point(9, 47);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(91, 16);
            this.txtID.TabIndex = 0;
            this.txtID.Text = "Mã bệnh nhân";
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresh.Location = new System.Drawing.Point(425, 90);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(101, 35);
            this.BtnRefresh.TabIndex = 8;
            this.BtnRefresh.Text = "Xóa tìm kiếm";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSearch.Location = new System.Drawing.Point(425, 44);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(101, 35);
            this.BtnSearch.TabIndex = 7;
            this.BtnSearch.Text = "Tìm kiếm";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.Location = new System.Drawing.Point(12, 191);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(123, 35);
            this.BtnAdd.TabIndex = 4;
            this.BtnAdd.Text = "Thêm thông tin";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.Location = new System.Drawing.Point(153, 189);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(123, 35);
            this.BtnEdit.TabIndex = 5;
            this.BtnEdit.Text = "Chỉnh sửa";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.Location = new System.Drawing.Point(285, 189);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(123, 35);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "Xóa thông tin";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // boxHealth
            // 
            this.boxHealth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.boxHealth.Location = new System.Drawing.Point(153, 134);
            this.boxHealth.Name = "boxHealth";
            this.boxHealth.Size = new System.Drawing.Size(255, 22);
            this.boxHealth.TabIndex = 3;
            // 
            // txtHealth
            // 
            this.txtHealth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtHealth.AutoSize = true;
            this.txtHealth.Location = new System.Drawing.Point(9, 137);
            this.txtHealth.Name = "txtHealth";
            this.txtHealth.Size = new System.Drawing.Size(123, 16);
            this.txtHealth.TabIndex = 0;
            this.txtHealth.Text = "Tình trạng sức khỏe";
            // 
            // cbBoxType
            // 
            this.cbBoxType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cbBoxType.FormattingEnabled = true;
            this.cbBoxType.Items.AddRange(new object[] {
            "F0",
            "F1"});
            this.cbBoxType.Location = new System.Drawing.Point(153, 87);
            this.cbBoxType.Name = "cbBoxType";
            this.cbBoxType.Size = new System.Drawing.Size(255, 24);
            this.cbBoxType.TabIndex = 2;
            // 
            // txtType
            // 
            this.txtType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtType.AutoSize = true;
            this.txtType.Location = new System.Drawing.Point(9, 90);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(108, 16);
            this.txtType.TabIndex = 0;
            this.txtType.Text = "Phân loại cách ly";
            // 
            // gridHealth
            // 
            this.gridHealth.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridHealth.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHealth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridHealth.Location = new System.Drawing.Point(0, 240);
            this.gridHealth.Name = "gridHealth";
            this.gridHealth.ReadOnly = true;
            this.gridHealth.RowHeadersVisible = false;
            this.gridHealth.RowHeadersWidth = 51;
            this.gridHealth.RowTemplate.Height = 24;
            this.gridHealth.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridHealth.Size = new System.Drawing.Size(907, 311);
            this.gridHealth.TabIndex = 9;
            // 
            // HealthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 583);
            this.Controls.Add(this.gridHealth);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelSideRight);
            this.Name = "HealthForm";
            this.Text = "HealthForm";
            this.Load += new System.EventHandler(this.HealthForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridHealth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSideRight;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.DataGridView gridHealth;
        private System.Windows.Forms.Label txtType;
        private System.Windows.Forms.Label txtHealth;
        private System.Windows.Forms.ComboBox cbBoxType;
        private System.Windows.Forms.TextBox boxHealth;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.TextBox boxID;
        private System.Windows.Forms.Label txtID;
        private System.Windows.Forms.DataGridView gridID;
        private System.Windows.Forms.Label label1;
    }
}