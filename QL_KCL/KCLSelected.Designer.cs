namespace QL_KCL
{
    partial class KCLSelected
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtKCL = new System.Windows.Forms.Label();
            this.cbBoxKCL = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtKCL
            // 
            this.txtKCL.AutoSize = true;
            this.txtKCL.Location = new System.Drawing.Point(14, 17);
            this.txtKCL.Name = "txtKCL";
            this.txtKCL.Size = new System.Drawing.Size(74, 16);
            this.txtKCL.TabIndex = 0;
            this.txtKCL.Text = "Khu cách ly";
            // 
            // cbBoxKCL
            // 
            this.cbBoxKCL.FormattingEnabled = true;
            this.cbBoxKCL.Location = new System.Drawing.Point(125, 14);
            this.cbBoxKCL.Name = "cbBoxKCL";
            this.cbBoxKCL.Size = new System.Drawing.Size(242, 24);
            this.cbBoxKCL.TabIndex = 1;
            // 
            // KCLSelected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.cbBoxKCL);
            this.Controls.Add(this.txtKCL);
            this.Name = "KCLSelected";
            this.Size = new System.Drawing.Size(401, 56);
            this.Load += new System.EventHandler(this.KCLSelected_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtKCL;
        private System.Windows.Forms.ComboBox cbBoxKCL;
    }
}
