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
            this.BtnStatus = new System.Windows.Forms.Button();
            this.BtnVictim = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.exitButton1 = new QL_KCL.ExitButton();
            this.panelControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.BtnStatus);
            this.panelControl.Controls.Add(this.BtnVictim);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(204, 633);
            this.panelControl.TabIndex = 1;
            // 
            // BtnStatus
            // 
            this.BtnStatus.Location = new System.Drawing.Point(30, 417);
            this.BtnStatus.Name = "BtnStatus";
            this.BtnStatus.Size = new System.Drawing.Size(153, 35);
            this.BtnStatus.TabIndex = 1;
            this.BtnStatus.Text = "Tình trạng sức khỏe";
            this.BtnStatus.UseVisualStyleBackColor = true;
            this.BtnStatus.Click += new System.EventHandler(this.BtnStatus_Click);
            // 
            // BtnVictim
            // 
            this.BtnVictim.Location = new System.Drawing.Point(30, 492);
            this.BtnVictim.Name = "BtnVictim";
            this.BtnVictim.Size = new System.Drawing.Size(153, 35);
            this.BtnVictim.TabIndex = 0;
            this.BtnVictim.Text = "Quản lý bệnh nhân";
            this.BtnVictim.UseVisualStyleBackColor = true;
            this.BtnVictim.Click += new System.EventHandler(this.BtnVictim_Click);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(204, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(876, 633);
            this.panelMain.TabIndex = 2;
            // 
            // exitButton1
            // 
            this.exitButton1.Location = new System.Drawing.Point(30, 566);
            this.exitButton1.Name = "exitButton1";
            this.exitButton1.Size = new System.Drawing.Size(153, 35);
            this.exitButton1.TabIndex = 0;
            // 
            // DoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 633);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.exitButton1);
            this.Controls.Add(this.panelControl);
            this.Name = "DoctorForm";
            this.Text = "DoctorForm";
            this.Load += new System.EventHandler(this.DoctorForm_Load);
            this.panelControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ExitButton exitButton1;
        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Button BtnVictim;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button BtnStatus;
    }
}