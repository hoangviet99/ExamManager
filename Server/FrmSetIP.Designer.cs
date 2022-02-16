
namespace Server
{
    partial class FrmSetIP
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
            this.txtStartIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubnetMask = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLastIP = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtStartIP
            // 
            this.txtStartIP.Location = new System.Drawing.Point(71, 50);
            this.txtStartIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtStartIP.Name = "txtStartIP";
            this.txtStartIP.Size = new System.Drawing.Size(136, 22);
            this.txtStartIP.TabIndex = 0;
            this.txtStartIP.Text = "192.168.1.1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(403, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập vào dãy ip của các máy con:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "đến";
            // 
            // txtSubnetMask
            // 
            this.txtSubnetMask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSubnetMask.Location = new System.Drawing.Point(143, 116);
            this.txtSubnetMask.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubnetMask.Name = "txtSubnetMask";
            this.txtSubnetMask.Size = new System.Drawing.Size(164, 22);
            this.txtSubnetMask.TabIndex = 0;
            this.txtSubnetMask.Text = "255.255.255.0";
            this.txtSubnetMask.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(16, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(403, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhập vào subnet mask của các máy con:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(99, 164);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(241, 33);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "Chấp nhận";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Từ";
            // 
            // txtLastIP
            // 
            this.txtLastIP.Location = new System.Drawing.Point(255, 50);
            this.txtLastIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastIP.Name = "txtLastIP";
            this.txtLastIP.Size = new System.Drawing.Size(144, 22);
            this.txtLastIP.TabIndex = 5;
            this.txtLastIP.Text = "192.168.1.40";
            // 
            // FrmSetIP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 210);
            this.Controls.Add(this.txtLastIP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSubnetMask);
            this.Controls.Add(this.txtStartIP);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSetIP";
            this.Text = "FrmSetIP";
            this.Load += new System.EventHandler(this.FrmSetIP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtStartIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubnetMask;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLastIP;
    }
}