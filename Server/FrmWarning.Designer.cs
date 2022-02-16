
namespace Server
{
    partial class FrmWarning
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
            this.lblNotification = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNotification
            // 
            this.lblNotification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotification.ForeColor = System.Drawing.Color.Red;
            this.lblNotification.Location = new System.Drawing.Point(12, 9);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(423, 87);
            this.lblNotification.TabIndex = 0;
            this.lblNotification.Text = "label1";
            this.lblNotification.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(447, 105);
            this.Controls.Add(this.lblNotification);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmWarning";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cảnh báo";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNotification;
    }
}