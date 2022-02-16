
namespace Server
{
    partial class FrmSendMessage
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
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.btnSent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessage.Location = new System.Drawing.Point(12, 12);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(458, 261);
            this.txtMessage.TabIndex = 0;
            this.txtMessage.Text = "abc";
            // 
            // btnSent
            // 
            this.btnSent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSent.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSent.Location = new System.Drawing.Point(107, 290);
            this.btnSent.Name = "btnSent";
            this.btnSent.Size = new System.Drawing.Size(279, 40);
            this.btnSent.TabIndex = 1;
            this.btnSent.Text = "Gửi";
            this.btnSent.UseVisualStyleBackColor = true;
            this.btnSent.Click += new System.EventHandler(this.btnSent_Click);
            // 
            // FrmSendMessage
            // 
            this.AcceptButton = this.btnSent;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 342);
            this.Controls.Add(this.btnSent);
            this.Controls.Add(this.txtMessage);
            this.Name = "FrmSendMessage";
            this.Text = "Gửi thông điệp cho tất cả sinh viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Button btnSent;
    }
}