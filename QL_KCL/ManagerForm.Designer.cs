namespace QL_KCL
{
    partial class ManagerForm
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
            this.BtnStaff = new System.Windows.Forms.Button();
            this.panelControl = new System.Windows.Forms.Panel();
            this.BtnReport = new System.Windows.Forms.Button();
            this.logoutButton = new QL_KCL.LogoutButton();
            this.txtUserName = new System.Windows.Forms.Label();
            this.txtHello = new System.Windows.Forms.Label();
            this.ExitButton = new QL_KCL.ExitButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnStaff
            // 
            this.BtnStaff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStaff.Location = new System.Drawing.Point(31, 372);
            this.BtnStaff.Name = "BtnStaff";
            this.BtnStaff.Size = new System.Drawing.Size(140, 35);
            this.BtnStaff.TabIndex = 1;
            this.BtnStaff.Text = "Quản lý nhân viên";
            this.BtnStaff.UseVisualStyleBackColor = true;
            this.BtnStaff.Click += new System.EventHandler(this.BtnStaff_Click);
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.BtnReport);
            this.panelControl.Controls.Add(this.logoutButton);
            this.panelControl.Controls.Add(this.txtUserName);
            this.panelControl.Controls.Add(this.txtHello);
            this.panelControl.Controls.Add(this.BtnStaff);
            this.panelControl.Controls.Add(this.ExitButton);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(200, 683);
            this.panelControl.TabIndex = 2;
            // 
            // BtnReport
            // 
            this.BtnReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReport.Location = new System.Drawing.Point(31, 438);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(140, 35);
            this.BtnReport.TabIndex = 2;
            this.BtnReport.Text = "Xuất báo cáo";
            this.BtnReport.UseVisualStyleBackColor = true;
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.Location = new System.Drawing.Point(31, 509);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(140, 35);
            this.logoutButton.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.AutoSize = true;
            this.txtUserName.Location = new System.Drawing.Point(94, 29);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(70, 16);
            this.txtUserName.TabIndex = 8;
            this.txtUserName.Text = "Username";
            // 
            // txtHello
            // 
            this.txtHello.AutoSize = true;
            this.txtHello.Location = new System.Drawing.Point(28, 29);
            this.txtHello.Name = "txtHello";
            this.txtHello.Size = new System.Drawing.Size(58, 16);
            this.txtHello.TabIndex = 7;
            this.txtHello.Text = "Xin chào";
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Location = new System.Drawing.Point(31, 577);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(140, 35);
            this.ExitButton.TabIndex = 4;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(200, 0);
            this.panelMain.MinimumSize = new System.Drawing.Size(1300, 684);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1700, 684);
            this.panelMain.TabIndex = 3;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1900, 683);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelControl);
            this.MinimumSize = new System.Drawing.Size(1918, 719);
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giám đốc";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ExitButton ExitButton;
        private System.Windows.Forms.Button BtnStaff;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label txtHello;
        private System.Windows.Forms.Label txtUserName;
        private LogoutButton logoutButton;
        private System.Windows.Forms.Button BtnReport;
    }
}