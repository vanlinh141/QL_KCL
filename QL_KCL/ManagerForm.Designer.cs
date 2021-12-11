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
            this.exitButton1 = new QL_KCL.ExitButton();
            this.SuspendLayout();
            // 
            // exitButton1
            // 
            this.exitButton1.Location = new System.Drawing.Point(628, 388);
            this.exitButton1.Name = "exitButton1";
            this.exitButton1.Size = new System.Drawing.Size(133, 35);
            this.exitButton1.TabIndex = 0;
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitButton1);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.Load += new System.EventHandler(this.ManagerForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ExitButton exitButton1;
    }
}