
namespace Server
{
    partial class uc_Computer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblComputerName = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.picComputer = new System.Windows.Forms.PictureBox();
            this.grpComputer = new System.Windows.Forms.GroupBox();
            this.lblUsername = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer)).BeginInit();
            this.grpComputer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên máy:";
            this.label1.Click += new System.EventHandler(this.grpComputer_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "MSSV:";
            this.label2.Click += new System.EventHandler(this.grpComputer_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên SV:";
            this.label3.Click += new System.EventHandler(this.grpComputer_Click);
            // 
            // lblComputerName
            // 
            this.lblComputerName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblComputerName.AutoSize = true;
            this.lblComputerName.Location = new System.Drawing.Point(84, 180);
            this.lblComputerName.Name = "lblComputerName";
            this.lblComputerName.Size = new System.Drawing.Size(50, 17);
            this.lblComputerName.TabIndex = 4;
            this.lblComputerName.Text = "PC301";
            this.lblComputerName.Click += new System.EventHandler(this.grpComputer_Click);
            // 
            // lblStudentID
            // 
            this.lblStudentID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(84, 209);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(64, 17);
            this.lblStudentID.TabIndex = 5;
            this.lblStudentID.Text = "1710303";
            this.lblStudentID.Click += new System.EventHandler(this.grpComputer_Click);
            // 
            // lblStudentName
            // 
            this.lblStudentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(84, 238);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(118, 17);
            this.lblStudentName.TabIndex = 6;
            this.lblStudentName.Text = "Phạm Hoàng Việt";
            this.lblStudentName.Click += new System.EventHandler(this.grpComputer_Click);
            // 
            // picComputer
            // 
            this.picComputer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picComputer.Image = global::Server.Properties.Resources.computer1;
            this.picComputer.Location = new System.Drawing.Point(16, 21);
            this.picComputer.Name = "picComputer";
            this.picComputer.Size = new System.Drawing.Size(223, 150);
            this.picComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picComputer.TabIndex = 0;
            this.picComputer.TabStop = false;
            this.picComputer.Click += new System.EventHandler(this.grpComputer_Click);
            // 
            // grpComputer
            // 
            this.grpComputer.Controls.Add(this.lblUsername);
            this.grpComputer.Controls.Add(this.lblStudentName);
            this.grpComputer.Controls.Add(this.picComputer);
            this.grpComputer.Controls.Add(this.lblStudentID);
            this.grpComputer.Controls.Add(this.label1);
            this.grpComputer.Controls.Add(this.lblComputerName);
            this.grpComputer.Controls.Add(this.label2);
            this.grpComputer.Controls.Add(this.label3);
            this.grpComputer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpComputer.Location = new System.Drawing.Point(0, 0);
            this.grpComputer.Name = "grpComputer";
            this.grpComputer.Size = new System.Drawing.Size(256, 272);
            this.grpComputer.TabIndex = 7;
            this.grpComputer.TabStop = false;
            this.grpComputer.Text = "groupBox1";
            this.grpComputer.Click += new System.EventHandler(this.grpComputer_Click);
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsername.BackColor = System.Drawing.SystemColors.Control;
            this.lblUsername.Location = new System.Drawing.Point(16, 48);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(189, 35);
            this.lblUsername.TabIndex = 7;
            this.lblUsername.Text = "PC301";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUsername.Click += new System.EventHandler(this.grpComputer_Click);
            // 
            // uc_Computer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grpComputer);
            this.Name = "uc_Computer";
            this.Size = new System.Drawing.Size(256, 272);
            this.Load += new System.EventHandler(this.uc_Computer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picComputer)).EndInit();
            this.grpComputer.ResumeLayout(false);
            this.grpComputer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picComputer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblComputerName;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.GroupBox grpComputer;
        private System.Windows.Forms.Label lblUsername;
    }
}
