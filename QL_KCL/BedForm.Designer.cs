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
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
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
            // BtnEdit
            // 
            this.BtnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEdit.Location = new System.Drawing.Point(658, 87);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(103, 35);
            this.BtnEdit.TabIndex = 1;
            this.BtnEdit.Text = "Chỉnh sửa";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.Location = new System.Drawing.Point(658, 37);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(103, 35);
            this.BtnAdd.TabIndex = 2;
            this.BtnAdd.Text = "Thêm giường";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.Location = new System.Drawing.Point(658, 137);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(103, 35);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Xóa giường";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // gridBed
            // 
            this.gridBed.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBed.Location = new System.Drawing.Point(0, 191);
            this.gridBed.Name = "gridBed";
            this.gridBed.ReadOnly = true;
            this.gridBed.RowHeadersVisible = false;
            this.gridBed.RowHeadersWidth = 51;
            this.gridBed.RowTemplate.Height = 24;
            this.gridBed.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBed.Size = new System.Drawing.Size(767, 392);
            this.gridBed.TabIndex = 4;
            // 
            // txtBed
            // 
            this.txtBed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtBed.AutoSize = true;
            this.txtBed.Location = new System.Drawing.Point(154, 53);
            this.txtBed.Name = "txtBed";
            this.txtBed.Size = new System.Drawing.Size(70, 16);
            this.txtBed.TabIndex = 11;
            this.txtBed.Text = "Mã giường";
            // 
            // boxBedID
            // 
            this.boxBedID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
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
            this.panelHeader.Size = new System.Drawing.Size(767, 191);
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
            this.roomSelected.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnEdit);
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

        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.DataGridView gridBed;
        private RoomSelected roomSelected;
        private System.Windows.Forms.Label txtBed;
        private System.Windows.Forms.TextBox boxBedID;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelSideRight;
        private System.Windows.Forms.Panel panelFooter;
    }
}