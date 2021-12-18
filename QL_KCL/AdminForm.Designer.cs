namespace QL_KCL
{
    partial class AdminForm
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
            this.txtUsername = new System.Windows.Forms.Label();
            this.txtHello = new System.Windows.Forms.Label();
            this.BtnAccount = new System.Windows.Forms.Button();
            this.logoutButton = new QL_KCL.LogoutButton();
            this.exitButton1 = new QL_KCL.ExitButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.txtUsername);
            this.panelControl.Controls.Add(this.txtHello);
            this.panelControl.Controls.Add(this.BtnAccount);
            this.panelControl.Controls.Add(this.logoutButton);
            this.panelControl.Controls.Add(this.exitButton1);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(178, 589);
            this.panelControl.TabIndex = 1;
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSize = true;
            this.txtUsername.Location = new System.Drawing.Point(90, 29);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(70, 16);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.Text = "Username";
            // 
            // txtHello
            // 
            this.txtHello.AutoSize = true;
            this.txtHello.Location = new System.Drawing.Point(26, 29);
            this.txtHello.Name = "txtHello";
            this.txtHello.Size = new System.Drawing.Size(58, 16);
            this.txtHello.TabIndex = 3;
            this.txtHello.Text = "Xin chào";
            // 
            // BtnAccount
            // 
            this.BtnAccount.Location = new System.Drawing.Point(24, 263);
            this.BtnAccount.Name = "BtnAccount";
            this.BtnAccount.Size = new System.Drawing.Size(133, 35);
            this.BtnAccount.TabIndex = 0;
            this.BtnAccount.Text = "Quản lý tài khoản";
            this.BtnAccount.UseVisualStyleBackColor = true;
            this.BtnAccount.Click += new System.EventHandler(this.BtnAccount_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.Location = new System.Drawing.Point(24, 324);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(133, 35);
            this.logoutButton.TabIndex = 1;
            // 
            // exitButton1
            // 
            this.exitButton1.Location = new System.Drawing.Point(24, 384);
            this.exitButton1.Name = "exitButton1";
            this.exitButton1.Size = new System.Drawing.Size(133, 35);
            this.exitButton1.TabIndex = 2;
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(178, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1060, 589);
            this.panelMain.TabIndex = 2;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1238, 589);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelControl);
            this.MinimumSize = new System.Drawing.Size(1256, 636);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản trị viên";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ExitButton exitButton1;
        private System.Windows.Forms.Panel panelControl;
        private LogoutButton logoutButton;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button BtnAccount;
        private System.Windows.Forms.Label txtUsername;
        private System.Windows.Forms.Label txtHello;
    }
}