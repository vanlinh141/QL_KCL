namespace QL_KCL
{
    partial class BedSelected
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
            this.cbBoxBed = new System.Windows.Forms.ComboBox();
            this.txtBed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbBoxBed
            // 
            this.cbBoxBed.FormattingEnabled = true;
            this.cbBoxBed.Location = new System.Drawing.Point(125, 14);
            this.cbBoxBed.Name = "cbBoxBed";
            this.cbBoxBed.Size = new System.Drawing.Size(242, 24);
            this.cbBoxBed.TabIndex = 0;
            // 
            // txtBed
            // 
            this.txtBed.AutoSize = true;
            this.txtBed.Location = new System.Drawing.Point(14, 17);
            this.txtBed.Name = "txtBed";
            this.txtBed.Size = new System.Drawing.Size(50, 16);
            this.txtBed.TabIndex = 1;
            this.txtBed.Text = "Giường";
            // 
            // BedSelected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.txtBed);
            this.Controls.Add(this.cbBoxBed);
            this.Name = "BedSelected";
            this.Size = new System.Drawing.Size(401, 56);
            this.Load += new System.EventHandler(this.BedSelected_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBoxBed;
        private System.Windows.Forms.Label txtBed;
    }
}
