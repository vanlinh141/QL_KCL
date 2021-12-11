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
            this.txtUserName = new System.Windows.Forms.Label();
            this.txtHello = new System.Windows.Forms.Label();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnBed = new System.Windows.Forms.Button();
            this.logoutButton = new QL_KCL.LogoutButton();
            this.btnDevice = new System.Windows.Forms.Button();
            this.exitButton = new QL_KCL.ExitButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.txtUserName);
            this.panelControl.Controls.Add(this.txtHello);
            this.panelControl.Controls.Add(this.btnTest);
            this.panelControl.Controls.Add(this.btnBed);
            this.panelControl.Controls.Add(this.logoutButton);
            this.panelControl.Controls.Add(this.btnDevice);
            this.panelControl.Controls.Add(this.exitButton);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(204, 633);
            this.panelControl.TabIndex = 1;
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
            // btnTest
            // 
            this.btnTest.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTest.Location = new System.Drawing.Point(29, 215);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(153, 35);
            this.btnTest.TabIndex = 5;
            this.btnTest.Text = "Kết quả xét nghiệm";
            this.btnTest.UseVisualStyleBackColor = true;
            // 
            // btnBed
            // 
            this.btnBed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBed.Location = new System.Drawing.Point(29, 306);
            this.btnBed.Name = "btnBed";
            this.btnBed.Size = new System.Drawing.Size(153, 35);
            this.btnBed.TabIndex = 4;
            this.btnBed.Text = "Quản lý giường";
            this.btnBed.UseVisualStyleBackColor = true;
            this.btnBed.Click += new System.EventHandler(this.btnBed_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.logoutButton.Location = new System.Drawing.Point(29, 472);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(153, 35);
            this.logoutButton.TabIndex = 3;
            // 
            // btnDevice
            // 
            this.btnDevice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDevice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevice.Location = new System.Drawing.Point(29, 391);
            this.btnDevice.Name = "btnDevice";
            this.btnDevice.Size = new System.Drawing.Size(153, 35);
            this.btnDevice.TabIndex = 2;
            this.btnDevice.Text = "Quản lý thiết bị";
            this.btnDevice.UseVisualStyleBackColor = true;
            this.btnDevice.Click += new System.EventHandler(this.btnDevice_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitButton.Location = new System.Drawing.Point(29, 548);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(153, 35);
            this.exitButton.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(204, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(876, 633);
            this.panelMain.TabIndex = 2;
            // 
            // NursingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 633);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelControl);
            this.MinimumSize = new System.Drawing.Size(1080, 633);
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
        private System.Windows.Forms.Button btnDevice;
        private System.Windows.Forms.Panel panelMain;
        private LogoutButton logoutButton;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Button btnBed;
        private System.Windows.Forms.Label txtUserName;
        private System.Windows.Forms.Label txtHello;
    }
}