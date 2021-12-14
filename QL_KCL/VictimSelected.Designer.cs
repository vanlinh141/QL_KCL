namespace QL_KCL
{
    partial class VictimSelected
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
            this.cbBoxVictim = new System.Windows.Forms.ComboBox();
            this.txtVictim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbBoxVictim
            // 
            this.cbBoxVictim.FormattingEnabled = true;
            this.cbBoxVictim.Location = new System.Drawing.Point(125, 14);
            this.cbBoxVictim.Name = "cbBoxVictim";
            this.cbBoxVictim.Size = new System.Drawing.Size(242, 24);
            this.cbBoxVictim.TabIndex = 0;
            // 
            // txtVictim
            // 
            this.txtVictim.AutoSize = true;
            this.txtVictim.Location = new System.Drawing.Point(14, 17);
            this.txtVictim.Name = "txtVictim";
            this.txtVictim.Size = new System.Drawing.Size(91, 16);
            this.txtVictim.TabIndex = 2;
            this.txtVictim.Text = "Mã bệnh nhân";
            // 
            // VictimSelected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtVictim);
            this.Controls.Add(this.cbBoxVictim);
            this.Name = "VictimSelected";
            this.Size = new System.Drawing.Size(401, 56);
            this.Load += new System.EventHandler(this.VictimSelected_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBoxVictim;
        private System.Windows.Forms.Label txtVictim;
    }
}
