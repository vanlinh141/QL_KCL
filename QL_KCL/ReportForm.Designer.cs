namespace QL_KCL
{
    partial class ReportForm
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
            this.panelControl = new System.Windows.Forms.Panel();
            this.BtnListF1 = new System.Windows.Forms.Button();
            this.BtnListF0 = new System.Windows.Forms.Button();
            this.BtnVictimByMonth = new System.Windows.Forms.Button();
            this.BtnVictimByDay = new System.Windows.Forms.Button();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.BtnExport = new System.Windows.Forms.Button();
            this.panelSideRight = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gridMain = new System.Windows.Forms.DataGridView();
            this.BtnListVictimCheckOut = new System.Windows.Forms.Button();
            this.panelControl.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.panelSideRight.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelControl.Controls.Add(this.BtnListVictimCheckOut);
            this.panelControl.Controls.Add(this.BtnListF1);
            this.panelControl.Controls.Add(this.BtnListF0);
            this.panelControl.Controls.Add(this.BtnVictimByMonth);
            this.panelControl.Controls.Add(this.BtnVictimByDay);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(183, 487);
            this.panelControl.TabIndex = 0;
            // 
            // BtnListF1
            // 
            this.BtnListF1.Location = new System.Drawing.Point(12, 310);
            this.BtnListF1.Name = "BtnListF1";
            this.BtnListF1.Size = new System.Drawing.Size(157, 67);
            this.BtnListF1.TabIndex = 3;
            this.BtnListF1.Text = "Danh sách F1";
            this.BtnListF1.UseVisualStyleBackColor = true;
            this.BtnListF1.Click += new System.EventHandler(this.BtnListF1_Click);
            // 
            // BtnListF0
            // 
            this.BtnListF0.Location = new System.Drawing.Point(12, 215);
            this.BtnListF0.Name = "BtnListF0";
            this.BtnListF0.Size = new System.Drawing.Size(157, 67);
            this.BtnListF0.TabIndex = 2;
            this.BtnListF0.Text = "Danh sách F0";
            this.BtnListF0.UseVisualStyleBackColor = true;
            this.BtnListF0.Click += new System.EventHandler(this.BtnListF0_Click);
            // 
            // BtnVictimByMonth
            // 
            this.BtnVictimByMonth.Location = new System.Drawing.Point(12, 114);
            this.BtnVictimByMonth.Name = "BtnVictimByMonth";
            this.BtnVictimByMonth.Size = new System.Drawing.Size(157, 67);
            this.BtnVictimByMonth.TabIndex = 1;
            this.BtnVictimByMonth.Text = "Bệnh nhân dương tính tháng này";
            this.BtnVictimByMonth.UseVisualStyleBackColor = true;
            this.BtnVictimByMonth.Click += new System.EventHandler(this.BtnVictimByMonth_Click);
            // 
            // BtnVictimByDay
            // 
            this.BtnVictimByDay.Location = new System.Drawing.Point(12, 24);
            this.BtnVictimByDay.Name = "BtnVictimByDay";
            this.BtnVictimByDay.Size = new System.Drawing.Size(157, 67);
            this.BtnVictimByDay.TabIndex = 0;
            this.BtnVictimByDay.Text = "Bệnh nhân dương tính theo ngày";
            this.BtnVictimByDay.UseVisualStyleBackColor = true;
            this.BtnVictimByDay.Click += new System.EventHandler(this.BtnVictimByDay_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelFooter.Controls.Add(this.BtnExport);
            this.panelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFooter.Location = new System.Drawing.Point(183, 431);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(981, 56);
            this.panelFooter.TabIndex = 1;
            // 
            // BtnExport
            // 
            this.BtnExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExport.Location = new System.Drawing.Point(818, 11);
            this.BtnExport.Name = "BtnExport";
            this.BtnExport.Size = new System.Drawing.Size(135, 34);
            this.BtnExport.TabIndex = 0;
            this.BtnExport.Text = "Xuất ra file Excel";
            this.BtnExport.UseVisualStyleBackColor = true;
            this.BtnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // panelSideRight
            // 
            this.panelSideRight.Controls.Add(this.panel1);
            this.panelSideRight.Controls.Add(this.button4);
            this.panelSideRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSideRight.Location = new System.Drawing.Point(1136, 0);
            this.panelSideRight.Name = "panelSideRight";
            this.panelSideRight.Size = new System.Drawing.Size(28, 431);
            this.panelSideRight.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.button5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(28, 431);
            this.panel1.TabIndex = 3;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(860, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 36);
            this.button5.TabIndex = 0;
            this.button5.Text = "Xuất ra file Excel";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(860, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 36);
            this.button4.TabIndex = 0;
            this.button4.Text = "Xuất ra file Excel";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(183, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(953, 24);
            this.panelHeader.TabIndex = 3;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(183, 24);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(953, 407);
            this.panelMain.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gridMain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(953, 407);
            this.panel2.TabIndex = 0;
            // 
            // gridMain
            // 
            this.gridMain.AllowUserToAddRows = false;
            this.gridMain.AllowUserToDeleteRows = false;
            this.gridMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridMain.Location = new System.Drawing.Point(0, 0);
            this.gridMain.Name = "gridMain";
            this.gridMain.ReadOnly = true;
            this.gridMain.RowHeadersVisible = false;
            this.gridMain.RowHeadersWidth = 51;
            this.gridMain.RowTemplate.Height = 24;
            this.gridMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridMain.Size = new System.Drawing.Size(953, 407);
            this.gridMain.TabIndex = 0;
            // 
            // BtnListVictimCheckOut
            // 
            this.BtnListVictimCheckOut.Location = new System.Drawing.Point(12, 408);
            this.BtnListVictimCheckOut.Name = "BtnListVictimCheckOut";
            this.BtnListVictimCheckOut.Size = new System.Drawing.Size(157, 67);
            this.BtnListVictimCheckOut.TabIndex = 4;
            this.BtnListVictimCheckOut.Text = "Danh sách bênh nhân đủ tiêu chuẩn xuất viện";
            this.BtnListVictimCheckOut.UseVisualStyleBackColor = true;
            this.BtnListVictimCheckOut.Click += new System.EventHandler(this.BtnListVictimCheckOut_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 487);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.panelSideRight);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelControl);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            this.Load += new System.EventHandler(this.ReportForm_Load);
            this.panelControl.ResumeLayout(false);
            this.panelFooter.ResumeLayout(false);
            this.panelSideRight.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Button BtnExport;
        private System.Windows.Forms.Button BtnListF0;
        private System.Windows.Forms.Button BtnVictimByMonth;
        private System.Windows.Forms.Button BtnVictimByDay;
        private System.Windows.Forms.Panel panelSideRight;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView gridMain;
        private System.Windows.Forms.Button BtnListF1;
        private System.Windows.Forms.Button BtnListVictimCheckOut;
    }
}