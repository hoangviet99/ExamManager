
namespace Server
{
    partial class FrmViewStudentScreen
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
            this.picStudentScreen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picStudentScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // picStudentScreen
            // 
            this.picStudentScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picStudentScreen.Location = new System.Drawing.Point(0, 0);
            this.picStudentScreen.Name = "picStudentScreen";
            this.picStudentScreen.Size = new System.Drawing.Size(800, 503);
            this.picStudentScreen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picStudentScreen.TabIndex = 0;
            this.picStudentScreen.TabStop = false;
            // 
            // FrmViewStudentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 503);
            this.Controls.Add(this.picStudentScreen);
            this.Name = "FrmViewStudentScreen";
            this.Text = "Xem màn hình máy client";
            this.Load += new System.EventHandler(this.FrmViewStudentScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picStudentScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picStudentScreen;
    }
}