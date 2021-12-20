namespace QL_KCL
{
    partial class DoctorForm
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
            this.BtnReport = new System.Windows.Forms.Button();
            this.BtnStatus = new System.Windows.Forms.Button();
            this.BtnVictim = new System.Windows.Forms.Button();
            this.TxtHello = new System.Windows.Forms.Label();
            this.exitButton = new QL_KCL.ExitButton();
            this.logoutButton = new QL_KCL.LogoutButton();
            this.txtUsername = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.txtUsername);
            this.panelControl.Controls.Add(this.TxtHello);
            this.panelControl.Controls.Add(this.BtnReport);
            this.panelControl.Controls.Add(this.logoutButton);
            this.panelControl.Controls.Add(this.BtnStatus);
            this.panelControl.Controls.Add(this.BtnVictim);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(204, 633);
            this.panelControl.TabIndex = 1;
            // 
            // BtnReport
            // 
            this.BtnReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnReport.Location = new System.Drawing.Point(30, 436);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(153, 35);
            this.BtnReport.TabIndex = 3;
            this.BtnReport.Text = "Xuất báo cáo";
            this.BtnReport.UseVisualStyleBackColor = true;
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // BtnStatus
            // 
            this.BtnStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStatus.Location = new System.Drawing.Point(30, 362);
            this.BtnStatus.Name = "BtnStatus";
            this.BtnStatus.Size = new System.Drawing.Size(153, 35);
            this.BtnStatus.TabIndex = 1;
            this.BtnStatus.Text = "Tình trạng sức khỏe";
            this.BtnStatus.UseVisualStyleBackColor = true;
            this.BtnStatus.Click += new System.EventHandler(this.BtnStatus_Click);
            // 
            // BtnVictim
            // 
            this.BtnVictim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVictim.Location = new System.Drawing.Point(30, 284);
            this.BtnVictim.Name = "BtnVictim";
            this.BtnVictim.Size = new System.Drawing.Size(153, 35);
            this.BtnVictim.TabIndex = 0;
            this.BtnVictim.Text = "Quản lý bệnh nhân";
            this.BtnVictim.UseVisualStyleBackColor = true;
            this.BtnVictim.Click += new System.EventHandler(this.BtnVictim_Click);
            // 
            // TxtHello
            // 
            this.TxtHello.AutoSize = true;
            this.TxtHello.Location = new System.Drawing.Point(27, 32);
            this.TxtHello.Name = "TxtHello";
            this.TxtHello.Size = new System.Drawing.Size(58, 16);
            this.TxtHello.TabIndex = 4;
            this.TxtHello.Text = "Xin chào";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(30, 566);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(153, 35);
            this.exitButton.TabIndex = 4;
            // 
            // logoutButton
            // 
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.Location = new System.Drawing.Point(30, 505);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(153, 35);
            this.logoutButton.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSize = true;
            this.txtUsername.Location = new System.Drawing.Point(91, 32);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(70, 16);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.Text = "Username";
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(204, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1130, 633);
            this.panelMain.TabIndex = 5;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 633);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.panelControl);
            this.MinimumSize = new System.Drawing.Size(1352, 680);
            this.Name = "DoctorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorForm";
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ExitButton exitButton;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button BtnVictim;
        private LogoutButton logoutButton;
        private System.Windows.Forms.Button BtnStatus;
        private System.Windows.Forms.Button BtnReport;
        private System.Windows.Forms.Label TxtHello;
        private System.Windows.Forms.Label txtUsername;
        private System.Windows.Forms.Panel panelMain;
    }
}