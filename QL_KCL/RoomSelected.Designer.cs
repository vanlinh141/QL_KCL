namespace QL_KCL
{
    partial class RoomSelected
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
            this.txtRoom = new System.Windows.Forms.Label();
            this.cbBoxRoom = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtRoom
            // 
            this.txtRoom.AutoSize = true;
            this.txtRoom.Location = new System.Drawing.Point(37, 19);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(46, 16);
            this.txtRoom.TabIndex = 10;
            this.txtRoom.Text = "Phòng";
            this.txtRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbBoxRoom
            // 
            this.cbBoxRoom.FormattingEnabled = true;
            this.cbBoxRoom.Location = new System.Drawing.Point(104, 16);
            this.cbBoxRoom.Name = "cbBoxRoom";
            this.cbBoxRoom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbBoxRoom.Size = new System.Drawing.Size(206, 24);
            this.cbBoxRoom.TabIndex = 10;
            // 
            // RoomSelected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.cbBoxRoom);
            this.Controls.Add(this.txtRoom);
            this.Name = "RoomSelected";
            this.Size = new System.Drawing.Size(356, 54);
            this.Load += new System.EventHandler(this.RoomSelected_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtRoom;
        private System.Windows.Forms.ComboBox cbBoxRoom;
    }
}
