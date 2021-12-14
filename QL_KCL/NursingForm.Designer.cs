namespace QL_KCL
{
    partial class NursingForm
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
            this.BtnVictim = new System.Windows.Forms.Button();
            this.txtUserName = new System.Windows.Forms.Label();
            this.txtHello = new System.Windows.Forms.Label();
            this.BtnTest = new System.Windows.Forms.Button();
            this.BtnBed = new System.Windows.Forms.Button();
            this.BtnDevice = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.BtnHealth = new System.Windows.Forms.Button();
            this.logoutButton = new QL_KCL.LogoutButton();
            this.exitButton = new QL_KCL.ExitButton();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.BtnVictim);
            this.panelControl.Controls.Add(this.BtnHealth);
            this.panelControl.Controls.Add(this.txtUserName);
            this.panelControl.Controls.Add(this.txtHello);
            this.panelControl.Controls.Add(this.BtnTest);
            this.panelControl.Controls.Add(this.BtnBed);
            this.panelControl.Controls.Add(this.logoutButton);
            this.panelControl.Controls.Add(this.BtnDevice);
            this.panelControl.Controls.Add(this.exitButton);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(204, 633);
            this.panelControl.TabIndex = 1;
            // 
            // BtnVictim
            // 
            this.BtnVictim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnVictim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVictim.Location = new System.Drawing.Point(30, 170);
            this.BtnVictim.Name = "BtnVictim";
            this.BtnVictim.Size = new System.Drawing.Size(153, 35);
            this.BtnVictim.TabIndex = 1;
            this.BtnVictim.Text = "Quản lý bệnh nhân";
            this.BtnVictim.UseVisualStyleBackColor = true;
            this.BtnVictim.Click += new System.EventHandler(this.BtnVictim_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.AutoSize = true;
            this.txtUserName.Location = new System.Drawing.Point(94, 27);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(70, 16);
            this.txtUserName.TabIndex = 7;
            this.txtUserName.Text = "Username";
            // 
            // txtHello
            // 
            this.txtHello.AutoSize = true;
            this.txtHello.Location = new System.Drawing.Point(33, 27);
            this.txtHello.Name = "txtHello";
            this.txtHello.Size = new System.Drawing.Size(58, 16);
            this.txtHello.TabIndex = 6;
            this.txtHello.Text = "Xin chào";
            // 
            // BtnTest
            // 
            this.BtnTest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTest.Location = new System.Drawing.Point(30, 308);
            this.BtnTest.Name = "BtnTest";
            this.BtnTest.Size = new System.Drawing.Size(153, 35);
            this.BtnTest.TabIndex = 2;
            this.BtnTest.Text = "Kết quả xét nghiệm";
            this.BtnTest.UseVisualStyleBackColor = true;
            this.BtnTest.Click += new System.EventHandler(this.BtnTest_Click);
            // 
            // BtnBed
            // 
            this.BtnBed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnBed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBed.Location = new System.Drawing.Point(30, 378);
            this.BtnBed.Name = "BtnBed";
            this.BtnBed.Size = new System.Drawing.Size(153, 35);
            this.BtnBed.TabIndex = 3;
            this.BtnBed.Text = "Quản lý giường";
            this.BtnBed.UseVisualStyleBackColor = true;
            this.BtnBed.Click += new System.EventHandler(this.BtnBed_Click);
            // 
            // BtnDevice
            // 
            this.BtnDevice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnDevice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDevice.Location = new System.Drawing.Point(30, 443);
            this.BtnDevice.Name = "BtnDevice";
            this.BtnDevice.Size = new System.Drawing.Size(153, 35);
            this.BtnDevice.TabIndex = 4;
            this.BtnDevice.Text = "Quản lý thiết bị";
            this.BtnDevice.UseVisualStyleBackColor = true;
            this.BtnDevice.Click += new System.EventHandler(this.BtnDevice_Click);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(204, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(978, 633);
            this.panelMain.TabIndex = 2;
            // 
            // BtnHealth
            // 
            this.BtnHealth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnHealth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnHealth.Location = new System.Drawing.Point(30, 241);
            this.BtnHealth.Name = "BtnHealth";
            this.BtnHealth.Size = new System.Drawing.Size(153, 35);
            this.BtnHealth.TabIndex = 8;
            this.BtnHealth.Text = "Sức khỏe bệnh nhân";
            this.BtnHealth.UseVisualStyleBackColor = true;
            this.BtnHealth.Click += new System.EventHandler(this.BtnHealth_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.Location = new System.Drawing.Point(30, 505);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(153, 35);
            this.logoutButton.TabIndex = 5;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitButton.Location = new System.Drawing.Point(30, 566);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(153, 35);
            this.exitButton.TabIndex = 6;
            // 
            // NursingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 633);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelControl);
            this.MinimumSize = new System.Drawing.Size(1200, 633);
            this.Name = "NursingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Điều dưỡng";
            this.Load += new System.EventHandler(this.NursingForm_Load);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ExitButton exitButton;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button BtnDevice;
        private System.Windows.Forms.Panel panelMain;
        private LogoutButton logoutButton;
        private System.Windows.Forms.Button BtnTest;
        private System.Windows.Forms.Button BtnBed;
        private System.Windows.Forms.Label txtUserName;
        private System.Windows.Forms.Label txtHello;
        private System.Windows.Forms.Button BtnVictim;
        private System.Windows.Forms.Button BtnHealth;
    }
}