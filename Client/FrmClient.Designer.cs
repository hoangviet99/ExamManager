namespace Client
{
    partial class frmClient
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
            this.components = new System.ComponentModel.Container();
            this.cmbListStudentInfo = new System.Windows.Forms.ComboBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpStudentInfoChoice = new System.Windows.Forms.GroupBox();
            this.grpStudentInfo = new System.Windows.Forms.GroupBox();
            this.llbExamTitle = new System.Windows.Forms.LinkLabel();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblTimeRemain = new System.Windows.Forms.Label();
            this.lblWorkingTime = new System.Windows.Forms.Label();
            this.lblSubjectName = new System.Windows.Forms.Label();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tmrTimeRemain = new System.Windows.Forms.Timer(this.components);
            this.lblNote = new System.Windows.Forms.Label();
            this.grpStudentInfoChoice.SuspendLayout();
            this.grpStudentInfo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbListStudentInfo
            // 
            this.cmbListStudentInfo.FormattingEnabled = true;
            this.cmbListStudentInfo.Location = new System.Drawing.Point(15, 54);
            this.cmbListStudentInfo.Margin = new System.Windows.Forms.Padding(4);
            this.cmbListStudentInfo.Name = "cmbListStudentInfo";
            this.cmbListStudentInfo.Size = new System.Drawing.Size(344, 24);
            this.cmbListStudentInfo.TabIndex = 0;
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(380, 52);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(100, 28);
            this.btnAccept.TabIndex = 1;
            this.btnAccept.Text = "Chấp Nhận";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Chọn Tên  của mình sau đó nhấn vào nút Chấp Nhận";
            // 
            // grpStudentInfoChoice
            // 
            this.grpStudentInfoChoice.Controls.Add(this.label1);
            this.grpStudentInfoChoice.Controls.Add(this.btnAccept);
            this.grpStudentInfoChoice.Controls.Add(this.cmbListStudentInfo);
            this.grpStudentInfoChoice.Location = new System.Drawing.Point(5, 101);
            this.grpStudentInfoChoice.Margin = new System.Windows.Forms.Padding(4);
            this.grpStudentInfoChoice.Name = "grpStudentInfoChoice";
            this.grpStudentInfoChoice.Padding = new System.Windows.Forms.Padding(4);
            this.grpStudentInfoChoice.Size = new System.Drawing.Size(492, 97);
            this.grpStudentInfoChoice.TabIndex = 3;
            this.grpStudentInfoChoice.TabStop = false;
            this.grpStudentInfoChoice.Text = "Chọn Tên Sinh Viên";
            // 
            // grpStudentInfo
            // 
            this.grpStudentInfo.Controls.Add(this.llbExamTitle);
            this.grpStudentInfo.Controls.Add(this.lblStudentID);
            this.grpStudentInfo.Controls.Add(this.lblTimeRemain);
            this.grpStudentInfo.Controls.Add(this.lblWorkingTime);
            this.grpStudentInfo.Controls.Add(this.lblSubjectName);
            this.grpStudentInfo.Controls.Add(this.lblStudentName);
            this.grpStudentInfo.Controls.Add(this.label4);
            this.grpStudentInfo.Controls.Add(this.label10);
            this.grpStudentInfo.Controls.Add(this.label11);
            this.grpStudentInfo.Controls.Add(this.label8);
            this.grpStudentInfo.Controls.Add(this.label6);
            this.grpStudentInfo.Controls.Add(this.label2);
            this.grpStudentInfo.Location = new System.Drawing.Point(5, 220);
            this.grpStudentInfo.Margin = new System.Windows.Forms.Padding(4);
            this.grpStudentInfo.Name = "grpStudentInfo";
            this.grpStudentInfo.Padding = new System.Windows.Forms.Padding(4);
            this.grpStudentInfo.Size = new System.Drawing.Size(492, 212);
            this.grpStudentInfo.TabIndex = 4;
            this.grpStudentInfo.TabStop = false;
            this.grpStudentInfo.Text = "Thông Tin Sinh Viên";
            // 
            // llbExamTitle
            // 
            this.llbExamTitle.AutoSize = true;
            this.llbExamTitle.Location = new System.Drawing.Point(168, 144);
            this.llbExamTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.llbExamTitle.Name = "llbExamTitle";
            this.llbExamTitle.Size = new System.Drawing.Size(80, 17);
            this.llbExamTitle.TabIndex = 2;
            this.llbExamTitle.TabStop = true;
            this.llbExamTitle.Text = "Chưa có đề";
            this.llbExamTitle.Click += new System.EventHandler(this.llbExamTitle_Click);
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(168, 58);
            this.lblStudentID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(76, 17);
            this.lblStudentID.TabIndex = 1;
            this.lblStudentID.Text = "Chưa chọn";
            // 
            // lblTimeRemain
            // 
            this.lblTimeRemain.AutoSize = true;
            this.lblTimeRemain.Location = new System.Drawing.Point(168, 174);
            this.lblTimeRemain.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTimeRemain.Name = "lblTimeRemain";
            this.lblTimeRemain.Size = new System.Drawing.Size(93, 17);
            this.lblTimeRemain.TabIndex = 1;
            this.lblTimeRemain.Text = "Chưa bắt đầu";
            // 
            // lblWorkingTime
            // 
            this.lblWorkingTime.AutoSize = true;
            this.lblWorkingTime.Location = new System.Drawing.Point(168, 114);
            this.lblWorkingTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkingTime.Name = "lblWorkingTime";
            this.lblWorkingTime.Size = new System.Drawing.Size(64, 17);
            this.lblWorkingTime.TabIndex = 1;
            this.lblWorkingTime.Text = "120 phút";
            // 
            // lblSubjectName
            // 
            this.lblSubjectName.AutoSize = true;
            this.lblSubjectName.Location = new System.Drawing.Point(168, 87);
            this.lblSubjectName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubjectName.Name = "lblSubjectName";
            this.lblSubjectName.Size = new System.Drawing.Size(108, 17);
            this.lblSubjectName.TabIndex = 1;
            this.lblSubjectName.Text = "Lập Trình Mạng";
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(168, 31);
            this.lblStudentName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(76, 17);
            this.lblStudentName.TabIndex = 1;
            this.lblStudentName.Text = "Chưa chọn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "MSSV:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 144);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Đề Thi:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 174);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Thời Gian Còn Lại:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 114);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Thời Gian Làm Bài:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 87);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Môn Thi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ Tên Sinh Viên:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSubmit.Location = new System.Drawing.Point(161, 464);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(169, 36);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Nộp Bài Thi";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(95, 24);
            this.txtServerIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(264, 22);
            this.txtServerIP.TabIndex = 6;
            this.txtServerIP.Text = "localhost";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnConnect);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtServerIP);
            this.groupBox3.Location = new System.Drawing.Point(5, 12);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(492, 66);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Nhập địa chỉ IP Server";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(380, 21);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 28);
            this.btnConnect.TabIndex = 8;
            this.btnConnect.Text = "Kết Nối";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 27);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 17);
            this.label13.TabIndex = 7;
            this.label13.Text = "Server IP:";
            // 
            // tmrTimeRemain
            // 
            this.tmrTimeRemain.Enabled = true;
            this.tmrTimeRemain.Interval = 50;
            this.tmrTimeRemain.Tick += new System.EventHandler(this.tmrTimeRemain_Tick);
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.ForeColor = System.Drawing.Color.Red;
            this.lblNote.Location = new System.Drawing.Point(13, 436);
            this.lblNote.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(47, 17);
            this.lblNote.TabIndex = 3;
            this.lblNote.Text = "Lưu ý:";
            // 
            // frmClient
            // 
            this.AcceptButton = this.btnConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 513);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.grpStudentInfo);
            this.Controls.Add(this.grpStudentInfoChoice);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(530, 560);
            this.MinimumSize = new System.Drawing.Size(530, 560);
            this.Name = "frmClient";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmClient_FormClosing);
            this.Load += new System.EventHandler(this.frmClient_Load);
            this.grpStudentInfoChoice.ResumeLayout(false);
            this.grpStudentInfoChoice.PerformLayout();
            this.grpStudentInfo.ResumeLayout(false);
            this.grpStudentInfo.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbListStudentInfo;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpStudentInfoChoice;
        private System.Windows.Forms.GroupBox grpStudentInfo;
        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblWorkingTime;
        private System.Windows.Forms.Label lblSubjectName;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel llbExamTitle;
        private System.Windows.Forms.Label lblTimeRemain;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Timer tmrTimeRemain;
        private System.Windows.Forms.Label lblNote;
    }
}

