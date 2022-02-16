
namespace Server
{
    partial class FrmServer
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
            this.lstExams = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemoveExam = new System.Windows.Forms.Button();
            this.btnAddExam = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtClientPath = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grpTimeRemain = new System.Windows.Forms.GroupBox();
            this.lblTimeRemain = new System.Windows.Forms.Label();
            this.btnSelectClientPath = new System.Windows.Forms.Button();
            this.btnSelectServerPath = new System.Windows.Forms.Button();
            this.MainGroupBox = new System.Windows.Forms.GroupBox();
            this.flpListComputer = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.txtWorkingTime = new System.Windows.Forms.TextBox();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnAcceptSubjectInfo = new System.Windows.Forms.Button();
            this.btnSendMessageToAll = new System.Windows.Forms.Button();
            this.btnGetListStudentFormCSVFile = new System.Windows.Forms.Button();
            this.btnGetListStudentFormDatabase = new System.Windows.Forms.Button();
            this.btnDisableComputerNotConnect = new System.Windows.Forms.Button();
            this.btnStartExam = new System.Windows.Forms.Button();
            this.btnActiveAllClient = new System.Windows.Forms.Button();
            this.btnSetIPRange = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tmrServer = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnPreventApplication = new System.Windows.Forms.Button();
            this.btnRestartAll = new System.Windows.Forms.Button();
            this.btnShutDownAll = new System.Windows.Forms.Button();
            this.btnMakeRollCall = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblReadyStudent = new System.Windows.Forms.Label();
            this.lblTotalStudent = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.grpTimeRemain.SuspendLayout();
            this.MainGroupBox.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstExams
            // 
            this.lstExams.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstExams.FormattingEnabled = true;
            this.lstExams.HorizontalScrollbar = true;
            this.lstExams.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lstExams.ItemHeight = 16;
            this.lstExams.Items.AddRange(new object[] {
            "\\\\192.168.6.1\\dethi\\de1.htm",
            "\\\\192.168.6.1\\dethi\\de2.htm",
            "\\\\192.168.6.1\\dethi\\de3.htm",
            "\\\\192.168.6.3\\dethi\\de4.htm"});
            this.lstExams.Location = new System.Drawing.Point(9, 23);
            this.lstExams.Margin = new System.Windows.Forms.Padding(4);
            this.lstExams.Name = "lstExams";
            this.lstExams.Size = new System.Drawing.Size(319, 132);
            this.lstExams.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnRemoveExam);
            this.groupBox1.Controls.Add(this.btnAddExam);
            this.groupBox1.Controls.Add(this.lstExams);
            this.groupBox1.Location = new System.Drawing.Point(331, 610);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(463, 188);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Đề Thi";
            // 
            // btnRemoveExam
            // 
            this.btnRemoveExam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveExam.Location = new System.Drawing.Point(336, 92);
            this.btnRemoveExam.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveExam.Name = "btnRemoveExam";
            this.btnRemoveExam.Size = new System.Drawing.Size(117, 36);
            this.btnRemoveExam.TabIndex = 32;
            this.btnRemoveExam.Text = "Xóa Đề Thi";
            this.btnRemoveExam.UseVisualStyleBackColor = true;
            this.btnRemoveExam.Click += new System.EventHandler(this.btnRemoveExam_Click);
            // 
            // btnAddExam
            // 
            this.btnAddExam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddExam.Location = new System.Drawing.Point(336, 48);
            this.btnAddExam.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddExam.Name = "btnAddExam";
            this.btnAddExam.Size = new System.Drawing.Size(117, 36);
            this.btnAddExam.TabIndex = 31;
            this.btnAddExam.Text = "Thêm Đề Thi";
            this.btnAddExam.UseVisualStyleBackColor = true;
            this.btnAddExam.Click += new System.EventHandler(this.btnAddExam_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 33;
            this.label2.Text = "Server Path:";
            // 
            // txtServerPath
            // 
            this.txtServerPath.Location = new System.Drawing.Point(16, 44);
            this.txtServerPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtServerPath.Name = "txtServerPath";
            this.txtServerPath.Size = new System.Drawing.Size(159, 22);
            this.txtServerPath.TabIndex = 34;
            this.txtServerPath.Text = "E:\\Temp\\";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Client Path:";
            // 
            // txtClientPath
            // 
            this.txtClientPath.Location = new System.Drawing.Point(16, 101);
            this.txtClientPath.Margin = new System.Windows.Forms.Padding(4);
            this.txtClientPath.Name = "txtClientPath";
            this.txtClientPath.Size = new System.Drawing.Size(159, 22);
            this.txtClientPath.TabIndex = 34;
            this.txtClientPath.Text = "C:\\LamBaiThi\\";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.grpTimeRemain);
            this.groupBox3.Controls.Add(this.btnSelectClientPath);
            this.groupBox3.Controls.Add(this.btnSelectServerPath);
            this.groupBox3.Controls.Add(this.txtClientPath);
            this.groupBox3.Controls.Add(this.txtServerPath);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(19, 607);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(292, 192);
            this.groupBox3.TabIndex = 36;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chọn Đường Dẫn";
            // 
            // grpTimeRemain
            // 
            this.grpTimeRemain.Controls.Add(this.lblTimeRemain);
            this.grpTimeRemain.Location = new System.Drawing.Point(15, 130);
            this.grpTimeRemain.Name = "grpTimeRemain";
            this.grpTimeRemain.Size = new System.Drawing.Size(253, 55);
            this.grpTimeRemain.TabIndex = 0;
            this.grpTimeRemain.TabStop = false;
            this.grpTimeRemain.Text = "Thời gian làm bài còn lại";
            // 
            // lblTimeRemain
            // 
            this.lblTimeRemain.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeRemain.ForeColor = System.Drawing.Color.Red;
            this.lblTimeRemain.Location = new System.Drawing.Point(7, 18);
            this.lblTimeRemain.Name = "lblTimeRemain";
            this.lblTimeRemain.Size = new System.Drawing.Size(240, 34);
            this.lblTimeRemain.TabIndex = 0;
            this.lblTimeRemain.Text = "00 phút 00 giây";
            this.lblTimeRemain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSelectClientPath
            // 
            this.btnSelectClientPath.Location = new System.Drawing.Point(185, 98);
            this.btnSelectClientPath.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectClientPath.Name = "btnSelectClientPath";
            this.btnSelectClientPath.Size = new System.Drawing.Size(83, 28);
            this.btnSelectClientPath.TabIndex = 36;
            this.btnSelectClientPath.Text = "Chọn";
            this.btnSelectClientPath.UseVisualStyleBackColor = true;
            this.btnSelectClientPath.Click += new System.EventHandler(this.btnSelectClientPath_Click);
            // 
            // btnSelectServerPath
            // 
            this.btnSelectServerPath.Location = new System.Drawing.Point(185, 44);
            this.btnSelectServerPath.Margin = new System.Windows.Forms.Padding(4);
            this.btnSelectServerPath.Name = "btnSelectServerPath";
            this.btnSelectServerPath.Size = new System.Drawing.Size(83, 30);
            this.btnSelectServerPath.TabIndex = 35;
            this.btnSelectServerPath.Text = "Chọn";
            this.btnSelectServerPath.UseVisualStyleBackColor = true;
            this.btnSelectServerPath.Click += new System.EventHandler(this.btnSelectServerPath_Click);
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainGroupBox.Controls.Add(this.flpListComputer);
            this.MainGroupBox.Location = new System.Drawing.Point(184, 15);
            this.MainGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.MainGroupBox.Name = "MainGroupBox";
            this.MainGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.MainGroupBox.Size = new System.Drawing.Size(1155, 582);
            this.MainGroupBox.TabIndex = 37;
            this.MainGroupBox.TabStop = false;
            this.MainGroupBox.Text = "Danh Sách Các Máy Tính Trong Phòng Máy";
            // 
            // flpListComputer
            // 
            this.flpListComputer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpListComputer.AutoScroll = true;
            this.flpListComputer.Location = new System.Drawing.Point(7, 22);
            this.flpListComputer.Name = "flpListComputer";
            this.flpListComputer.Size = new System.Drawing.Size(1141, 553);
            this.flpListComputer.TabIndex = 0;
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Location = new System.Drawing.Point(14, 30);
            this.txtSubjectName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(146, 22);
            this.txtSubjectName.TabIndex = 28;
            this.txtSubjectName.Text = "Chọn Môn Thi";
            this.txtSubjectName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtWorkingTime
            // 
            this.txtWorkingTime.Location = new System.Drawing.Point(14, 73);
            this.txtWorkingTime.Margin = new System.Windows.Forms.Padding(4);
            this.txtWorkingTime.Name = "txtWorkingTime";
            this.txtWorkingTime.Size = new System.Drawing.Size(146, 22);
            this.txtWorkingTime.TabIndex = 28;
            this.txtWorkingTime.Text = "120";
            this.txtWorkingTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(9, 70);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(145, 37);
            this.btnDisconnect.TabIndex = 40;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.btnAcceptSubjectInfo);
            this.groupBox5.Controls.Add(this.txtWorkingTime);
            this.groupBox5.Controls.Add(this.txtSubjectName);
            this.groupBox5.Location = new System.Drawing.Point(968, 610);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(172, 188);
            this.groupBox5.TabIndex = 42;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Môn thi và Thời Gian";
            // 
            // btnAcceptSubjectInfo
            // 
            this.btnAcceptSubjectInfo.Location = new System.Drawing.Point(37, 127);
            this.btnAcceptSubjectInfo.Margin = new System.Windows.Forms.Padding(4);
            this.btnAcceptSubjectInfo.Name = "btnAcceptSubjectInfo";
            this.btnAcceptSubjectInfo.Size = new System.Drawing.Size(108, 28);
            this.btnAcceptSubjectInfo.TabIndex = 29;
            this.btnAcceptSubjectInfo.Text = "Chấp Nhận";
            this.btnAcceptSubjectInfo.UseVisualStyleBackColor = true;
            this.btnAcceptSubjectInfo.Click += new System.EventHandler(this.btnAcceptSubjectInfo_Click);
            // 
            // btnSendMessageToAll
            // 
            this.btnSendMessageToAll.Location = new System.Drawing.Point(9, 116);
            this.btnSendMessageToAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendMessageToAll.Name = "btnSendMessageToAll";
            this.btnSendMessageToAll.Size = new System.Drawing.Size(145, 49);
            this.btnSendMessageToAll.TabIndex = 40;
            this.btnSendMessageToAll.Text = "Gửi thông điệp cho tất cả sinh viên";
            this.btnSendMessageToAll.UseVisualStyleBackColor = true;
            this.btnSendMessageToAll.Click += new System.EventHandler(this.btnSendMessageToAll_Click);
            // 
            // btnGetListStudentFormCSVFile
            // 
            this.btnGetListStudentFormCSVFile.Location = new System.Drawing.Point(9, 171);
            this.btnGetListStudentFormCSVFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetListStudentFormCSVFile.Name = "btnGetListStudentFormCSVFile";
            this.btnGetListStudentFormCSVFile.Size = new System.Drawing.Size(145, 53);
            this.btnGetListStudentFormCSVFile.TabIndex = 40;
            this.btnGetListStudentFormCSVFile.Text = "Lấy Danh Sách Thi Từ File";
            this.btnGetListStudentFormCSVFile.UseVisualStyleBackColor = true;
            this.btnGetListStudentFormCSVFile.Click += new System.EventHandler(this.btnGetListStudentFormCSVFile_Click);
            // 
            // btnGetListStudentFormDatabase
            // 
            this.btnGetListStudentFormDatabase.Location = new System.Drawing.Point(9, 233);
            this.btnGetListStudentFormDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetListStudentFormDatabase.Name = "btnGetListStudentFormDatabase";
            this.btnGetListStudentFormDatabase.Size = new System.Drawing.Size(145, 53);
            this.btnGetListStudentFormDatabase.TabIndex = 40;
            this.btnGetListStudentFormDatabase.Text = "Lấy Danh Sách Thi Từ CSDL";
            this.btnGetListStudentFormDatabase.UseVisualStyleBackColor = true;
            this.btnGetListStudentFormDatabase.Click += new System.EventHandler(this.btnGetListStudentFormDatabase_Click);
            // 
            // btnDisableComputerNotConnect
            // 
            this.btnDisableComputerNotConnect.Location = new System.Drawing.Point(9, 293);
            this.btnDisableComputerNotConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisableComputerNotConnect.Name = "btnDisableComputerNotConnect";
            this.btnDisableComputerNotConnect.Size = new System.Drawing.Size(145, 53);
            this.btnDisableComputerNotConnect.TabIndex = 40;
            this.btnDisableComputerNotConnect.Text = "Disable Tất Cả Các Máy Trống";
            this.btnDisableComputerNotConnect.UseVisualStyleBackColor = true;
            this.btnDisableComputerNotConnect.Click += new System.EventHandler(this.btnDisableComputerNotConnect_Click);
            // 
            // btnStartExam
            // 
            this.btnStartExam.Location = new System.Drawing.Point(9, 412);
            this.btnStartExam.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartExam.Name = "btnStartExam";
            this.btnStartExam.Size = new System.Drawing.Size(145, 39);
            this.btnStartExam.TabIndex = 44;
            this.btnStartExam.Text = "Bắt Đầu Làm Bài";
            this.btnStartExam.UseVisualStyleBackColor = true;
            this.btnStartExam.Click += new System.EventHandler(this.btnStartExam_Click);
            // 
            // btnActiveAllClient
            // 
            this.btnActiveAllClient.Location = new System.Drawing.Point(9, 354);
            this.btnActiveAllClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnActiveAllClient.Name = "btnActiveAllClient";
            this.btnActiveAllClient.Size = new System.Drawing.Size(145, 48);
            this.btnActiveAllClient.TabIndex = 45;
            this.btnActiveAllClient.Text = "Kích Hoạt Tất Cả Client";
            this.btnActiveAllClient.UseVisualStyleBackColor = true;
            this.btnActiveAllClient.Click += new System.EventHandler(this.btnActiveAllClient_Click);
            // 
            // btnSetIPRange
            // 
            this.btnSetIPRange.Location = new System.Drawing.Point(9, 26);
            this.btnSetIPRange.Margin = new System.Windows.Forms.Padding(4);
            this.btnSetIPRange.Name = "btnSetIPRange";
            this.btnSetIPRange.Size = new System.Drawing.Size(145, 37);
            this.btnSetIPRange.TabIndex = 46;
            this.btnSetIPRange.Text = "Nhập Vùng  IP";
            this.btnSetIPRange.UseVisualStyleBackColor = true;
            this.btnSetIPRange.Click += new System.EventHandler(this.btnSetIPRange_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox4.Controls.Add(this.btnSetIPRange);
            this.groupBox4.Controls.Add(this.btnActiveAllClient);
            this.groupBox4.Controls.Add(this.btnStartExam);
            this.groupBox4.Controls.Add(this.btnSendMessageToAll);
            this.groupBox4.Controls.Add(this.btnDisableComputerNotConnect);
            this.groupBox4.Controls.Add(this.btnGetListStudentFormDatabase);
            this.groupBox4.Controls.Add(this.btnGetListStudentFormCSVFile);
            this.groupBox4.Controls.Add(this.btnDisconnect);
            this.groupBox4.Location = new System.Drawing.Point(8, 15);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(165, 582);
            this.groupBox4.TabIndex = 47;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức Năng";
            // 
            // tmrServer
            // 
            this.tmrServer.Interval = 1000;
            this.tmrServer.Tick += new System.EventHandler(this.tmrServer_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnPreventApplication);
            this.groupBox2.Controls.Add(this.btnRestartAll);
            this.groupBox2.Controls.Add(this.btnShutDownAll);
            this.groupBox2.Location = new System.Drawing.Point(1149, 610);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(190, 188);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Điều khiển máy sinh viên";
            // 
            // btnPreventApplication
            // 
            this.btnPreventApplication.Location = new System.Drawing.Point(12, 136);
            this.btnPreventApplication.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreventApplication.Name = "btnPreventApplication";
            this.btnPreventApplication.Size = new System.Drawing.Size(165, 39);
            this.btnPreventApplication.TabIndex = 49;
            this.btnPreventApplication.Text = "Cấm chạy chương trình";
            this.btnPreventApplication.UseVisualStyleBackColor = true;
            this.btnPreventApplication.Click += new System.EventHandler(this.btnPreventApplication_Click);
            // 
            // btnRestartAll
            // 
            this.btnRestartAll.Location = new System.Drawing.Point(12, 73);
            this.btnRestartAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestartAll.Name = "btnRestartAll";
            this.btnRestartAll.Size = new System.Drawing.Size(165, 55);
            this.btnRestartAll.TabIndex = 48;
            this.btnRestartAll.Text = "Khởi động lại tất cả máy sinh viên";
            this.btnRestartAll.UseVisualStyleBackColor = true;
            this.btnRestartAll.Click += new System.EventHandler(this.btnRestartAll_Click);
            // 
            // btnShutDownAll
            // 
            this.btnShutDownAll.Location = new System.Drawing.Point(12, 26);
            this.btnShutDownAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnShutDownAll.Name = "btnShutDownAll";
            this.btnShutDownAll.Size = new System.Drawing.Size(165, 39);
            this.btnShutDownAll.TabIndex = 47;
            this.btnShutDownAll.Text = "Tắt tất cả máy";
            this.btnShutDownAll.UseVisualStyleBackColor = true;
            this.btnShutDownAll.Click += new System.EventHandler(this.btnShutDownAll_Click);
            // 
            // btnMakeRollCall
            // 
            this.btnMakeRollCall.Enabled = false;
            this.btnMakeRollCall.Location = new System.Drawing.Point(22, 111);
            this.btnMakeRollCall.Margin = new System.Windows.Forms.Padding(4);
            this.btnMakeRollCall.Name = "btnMakeRollCall";
            this.btnMakeRollCall.Size = new System.Drawing.Size(108, 60);
            this.btnMakeRollCall.TabIndex = 49;
            this.btnMakeRollCall.Text = "Điểm danh sinh viên";
            this.btnMakeRollCall.UseVisualStyleBackColor = true;
            this.btnMakeRollCall.Click += new System.EventHandler(this.btnMakeRollCall_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox6.Controls.Add(this.lblReadyStudent);
            this.groupBox6.Controls.Add(this.lblTotalStudent);
            this.groupBox6.Controls.Add(this.btnMakeRollCall);
            this.groupBox6.Location = new System.Drawing.Point(806, 610);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(150, 188);
            this.groupBox6.TabIndex = 48;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Trạng thái";
            // 
            // lblReadyStudent
            // 
            this.lblReadyStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadyStudent.Location = new System.Drawing.Point(6, 77);
            this.lblReadyStudent.Name = "lblReadyStudent";
            this.lblReadyStudent.Size = new System.Drawing.Size(138, 23);
            this.lblReadyStudent.TabIndex = 51;
            this.lblReadyStudent.Text = "Đã sẵn sàng: 35";
            this.lblReadyStudent.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblTotalStudent
            // 
            this.lblTotalStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStudent.Location = new System.Drawing.Point(6, 22);
            this.lblTotalStudent.Name = "lblTotalStudent";
            this.lblTotalStudent.Size = new System.Drawing.Size(138, 47);
            this.lblTotalStudent.TabIndex = 50;
            this.lblTotalStudent.Text = "Tổng SV: 35";
            this.lblTotalStudent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 804);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.MainGroupBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1100, 730);
            this.Name = "FrmServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmServer_FormClosing);
            this.Load += new System.EventHandler(this.FrmServer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.grpTimeRemain.ResumeLayout(false);
            this.MainGroupBox.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstExams;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServerPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtClientPath;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox MainGroupBox;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.TextBox txtWorkingTime;
        private System.Windows.Forms.Button btnSelectServerPath;
        private System.Windows.Forms.Button btnAddExam;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSendMessageToAll;
        private System.Windows.Forms.Button btnAcceptSubjectInfo;
        private System.Windows.Forms.Button btnGetListStudentFormCSVFile;
        private System.Windows.Forms.Button btnGetListStudentFormDatabase;
        private System.Windows.Forms.Button btnDisableComputerNotConnect;
        private System.Windows.Forms.Button btnStartExam;
        private System.Windows.Forms.Button btnSelectClientPath;
        private System.Windows.Forms.Button btnActiveAllClient;
        private System.Windows.Forms.Button btnSetIPRange;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnRemoveExam;
        private System.Windows.Forms.Timer tmrServer;
        private System.Windows.Forms.FlowLayoutPanel flpListComputer;
        private System.Windows.Forms.GroupBox grpTimeRemain;
        private System.Windows.Forms.Label lblTimeRemain;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMakeRollCall;
        private System.Windows.Forms.Button btnRestartAll;
        private System.Windows.Forms.Button btnShutDownAll;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblReadyStudent;
        private System.Windows.Forms.Label lblTotalStudent;
        private System.Windows.Forms.Button btnPreventApplication;
    }
}

