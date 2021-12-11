namespace QL_KCL
{
    partial class BedForm
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
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gridBed = new System.Windows.Forms.DataGridView();
            this.txtBed = new System.Windows.Forms.Label();
            this.boxBedID = new System.Windows.Forms.TextBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelSideRight = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.roomSelected = new QL_KCL.RoomSelected();
            ((System.ComponentModel.ISupportInitialize)(this.gridBed)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Location = new System.Drawing.Point(658, 88);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(103, 29);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Chỉnh sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Location = new System.Drawing.Point(658, 39);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 29);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm giường";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Location = new System.Drawing.Point(658, 134);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(103, 29);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa giường";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // gridBed
            // 
            this.gridBed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBed.Location = new System.Drawing.Point(0, 181);
            this.gridBed.Name = "gridBed";
            this.gridBed.ReadOnly = true;
            this.gridBed.RowHeadersVisible = false;
            this.gridBed.RowHeadersWidth = 51;
            this.gridBed.RowTemplate.Height = 24;
            this.gridBed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBed.Size = new System.Drawing.Size(767, 402);
            this.gridBed.TabIndex = 4;
            // 
            // txtBed
            // 
            this.txtBed.AutoSize = true;
            this.txtBed.Location = new System.Drawing.Point(154, 53);
            this.txtBed.Name = "txtBed";
            this.txtBed.Size = new System.Drawing.Size(70, 16);
            this.txtBed.TabIndex = 11;
            this.txtBed.Text = "Mã giường";
            // 
            // boxBedID
            // 
            this.boxBedID.Location = new System.Drawing.Point(243, 50);
            this.boxBedID.Name = "boxBedID";
            this.boxBedID.Size = new System.Drawing.Size(206, 22);
            this.boxBedID.TabIndex = 12;
            // 
            // panelHeader
            // 
            this.panelHeader.Controls.Add(this.boxBedID);
            this.panelHeader.Controls.Add(this.txtBed);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(767, 181);
            this.panelHeader.TabIndex = 13;
            // 
            // panelSideRight
            // 
            this.panelSideRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSideRight.Location = new System.Drawing.Point(767, 0);
            this.panelSideRight.Name = "panelSideRight";
            this.panelSideRight.Size = new System.Drawing.Size(33, 583);
            this.panelSideRight.TabIndex = 14;
            // 
            // panelFooter
            // 
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(0, 551);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(767, 32);
            this.panelFooter.TabIndex = 15;
            // 
            // roomSelected
            // 
            this.roomSelected.AutoSize = true;
            this.roomSelected.Location = new System.Drawing.Point(137, 105);
            this.roomSelected.Name = "roomSelected";
            this.roomSelected.Size = new System.Drawing.Size(337, 43);
            this.roomSelected.TabIndex = 10;
            // 
            // BedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 583);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.roomSelected);
            this.Controls.Add(this.gridBed);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSideRight);
            this.Name = "BedForm";
            this.Text = "Quản lý giường bệnh";
            this.Load += new System.EventHandler(this.BedForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridBed)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView gridBed;
        private RoomSelected roomSelected;
        private System.Windows.Forms.Label txtBed;
        private System.Windows.Forms.TextBox boxBedID;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelSideRight;
        private System.Windows.Forms.Panel panelFooter;
    }
}