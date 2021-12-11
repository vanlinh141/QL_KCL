namespace QL_KCL
{
    partial class LoginForm
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnExit = new QL_KCL.ExitButton();
            this.panelMain = new System.Windows.Forms.Panel();
            this.boxPass = new System.Windows.Forms.TextBox();
            this.boxEmail = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.Label();
            this.panelControl.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.btnLogin);
            this.panelControl.Controls.Add(this.btnExit);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl.Location = new System.Drawing.Point(0, 147);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(463, 78);
            this.panelControl.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.Location = new System.Drawing.Point(60, 20);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(133, 35);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExit.Location = new System.Drawing.Point(274, 20);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(133, 35);
            this.btnExit.TabIndex = 3;
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.boxPass);
            this.panelMain.Controls.Add(this.boxEmail);
            this.panelMain.Controls.Add(this.txtPass);
            this.panelMain.Controls.Add(this.txtEmail);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(463, 147);
            this.panelMain.TabIndex = 0;
            // 
            // boxPass
            // 
            this.boxPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.boxPass.Location = new System.Drawing.Point(162, 94);
            this.boxPass.Name = "boxPass";
            this.boxPass.PasswordChar = '*';
            this.boxPass.Size = new System.Drawing.Size(245, 24);
            this.boxPass.TabIndex = 1;
            this.boxPass.Text = "1";
            // 
            // boxEmail
            // 
            this.boxEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.boxEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.boxEmail.Location = new System.Drawing.Point(162, 44);
            this.boxEmail.Name = "boxEmail";
            this.boxEmail.Size = new System.Drawing.Size(245, 24);
            this.boxEmail.TabIndex = 0;
            this.boxEmail.Text = "nursing";
            // 
            // txtPass
            // 
            this.txtPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPass.AutoSize = true;
            this.txtPass.Location = new System.Drawing.Point(57, 97);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(61, 16);
            this.txtPass.TabIndex = 1;
            this.txtPass.Text = "Mật khẩu";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(57, 47);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(41, 16);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Text = "Email";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 225);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelControl);
            this.MaximumSize = new System.Drawing.Size(663, 425);
            this.MinimumSize = new System.Drawing.Size(463, 225);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginForm_KeyDown);
            this.panelControl.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControl;
        private ExitButton btnExit;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox boxPass;
        private System.Windows.Forms.TextBox boxEmail;
        private System.Windows.Forms.Label txtPass;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Button btnLogin;
    }
}