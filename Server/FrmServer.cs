using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Server.Enums;

namespace Server
{
    public partial class FrmServer : Form
    {
        public static int INTERVAL = 1;
        ServerProgram serverProgram;
        Thread threadReadExcelFile;
        int timeRemain;

        // ================================================== METHOD =====================================================
        private void GetListExam()
        {
            lstExams.Items.Clear();

            var listExam = ReadWrite.ReadExamList_FromFile();
            foreach (var item in listExam)
            {
                lstExams.Items.Add(item);
            }
        }

        private void SetSubjectInfo_ToServerProgram()
        {
            serverProgram.SubjectInfo.SubjectName = txtSubjectName.Text.Trim();
            serverProgram.SubjectInfo.WorkingTime = Int32.Parse(txtWorkingTime.Text.Trim());
        }

        private void GetSubjectInfo()
        {
            string textData = ReadWrite.ReadText_FromFile("SubjectInfo.txt");

            if (textData != null && textData != "")
            {
                string[] info = textData.Split('|');
                txtSubjectName.Text = info[0];
                txtWorkingTime.Text = info[1];

                SetSubjectInfo_ToServerProgram();
            }
        }

        private void ControlEventWhenStartExam()
        {
            tmrServer.Enabled = true;
            tmrServer.Interval = INTERVAL;
            grpTimeRemain.Visible = true;
            btnStartExam.Enabled = false;
            btnActiveAllClient.Enabled = false;
            btnAddExam.Enabled = false;
            btnRemoveExam.Enabled = false;
            btnAcceptSubjectInfo.Enabled = false;
            txtSubjectName.ReadOnly = true;
            txtWorkingTime.ReadOnly = true;
            txtClientPath.ReadOnly = true;
            txtServerPath.ReadOnly = true;
        }

        private void SetLabelNumReadyStudent(int numReadyStudent)
        {
            lblReadyStudent.Text = "Đã sẵn sàng: " + numReadyStudent;
        }

        private void SetStudentInfo(StudentInformation studentInfo, string ipAddress)
        {
            var ucComputer = serverProgram.ListComputer.Find(x => x.ComputerInfo.IPAddress.Equals(ipAddress));
            ucComputer.StudentInfo = studentInfo;
            ucComputer.ComputerInfo.ConnectState = CONNECTION_STATE.READY;

            ucComputer.UpdateInfo();
        }

        private void SendMessageToAll(string message)
        {
            serverProgram.SendMessageToAll(message);
        }

        private void SendListBlockingApplicationToAll(List<string> listApplication)
        {
            serverProgram.SendListBlockingApplicationToAll(listApplication);
        }

        private void GetListStudentInfo_FromExcel(string excelPath)
        {
            threadReadExcelFile = new Thread(() =>
            {
                serverProgram.ListStudentInfo = ReadWrite.ReadListStudentInfo_FromExcelFile(excelPath);
                if(serverProgram.ListStudentInfo != null)
                {
                    serverProgram.SendStudentInfo();
                    InitialStudentCallRoll();
                }
            });

            threadReadExcelFile.IsBackground = true;
            threadReadExcelFile.Start();
        }

        private void RenderListComputer(List<string> listIP)
        {
            flpListComputer.Controls.Clear();
            serverProgram.ListComputer = new List<uc_Computer>();

            #region Just for test, will be removed in future

            // Just for test, will be removed in future
            var ucComputer_Loopback = new uc_Computer(RequestViewStudentScreen);
            ucComputer_Loopback.ComputerInfo.IPAddress = "127.0.0.1";
            ucComputer_Loopback.ComputerInfo.ConnectState = CONNECTION_STATE.NOT_CONNECT;

            serverProgram.ListComputer.Add(ucComputer_Loopback);
            flpListComputer.Controls.Add(ucComputer_Loopback);
            // ========================================

            #endregion

            foreach (var ip in listIP)
            {
                var ucComputer = new uc_Computer(RequestViewStudentScreen);
                ucComputer.ComputerInfo.IPAddress = ip;
                ucComputer.ComputerInfo.ConnectState = CONNECTION_STATE.NOT_CONNECT;

                serverProgram.ListComputer.Add(ucComputer);
                flpListComputer.Controls.Add(ucComputer);
            }

            serverProgram.StartListen();
        }

        private void ShowPopupNotify(string notification)
        {
            var form = new FrmWarning(notification);
            form.BringToFront();
            form.TopMost = true;
            Task.Delay(TimeSpan.FromSeconds(5)).ContinueWith((t) => form.Close(), TaskScheduler.FromCurrentSynchronizationContext());

            form.Show();
        }

        private void InitialStudentCallRoll()
        {
            if(serverProgram.ListStudentInfo == null)
            {
                lblTotalStudent.Text = "Tổng SV: 0";
                lblReadyStudent.Text = "Đã sẵn sàng: 0";
                return;
            }
            btnMakeRollCall.Enabled = true;
            int totalStudent = serverProgram.ListStudentInfo.Count;

            lblTotalStudent.Text = "Tổng SV: " + totalStudent;
            lblReadyStudent.Text = "Đã sẵn sàng: 0";
        }

        private void UpdateComputerInfo(ComputerInformation computerInfo, StudentInformation studentInfo)
        {
            var ucComputer = serverProgram.ListComputer.Find(x => x.ComputerInfo.IPAddress.Equals(computerInfo.IPAddress));
            ucComputer.ComputerInfo = computerInfo;

            ucComputer.UpdateInfo();
        }

        private void RequestViewStudentScreen(ComputerInformation computerInfo)
        {
            Console.WriteLine();

            FrmViewStudentScreen form = new FrmViewStudentScreen();
            form.ComputerInfo = computerInfo;
            serverProgram.SetStudentScreenDisplay = form.SetStudentScreenDisplay;

            serverProgram.RequestViewStudentScreen(computerInfo.IPAddress);
            var dialogResult = form.ShowDialog();

            if(dialogResult == DialogResult.Cancel)
            {

            }
        }

        // ================================================== FORM LOAD =====================================================

        public FrmServer()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            serverProgram = new ServerProgram(9999);
            serverProgram.ServerPath = txtServerPath.Text;
        }

        private void FrmServer_Load(object sender, EventArgs e)
        {
            GetListExam();
            GetSubjectInfo();

            serverProgram.UpdateComputerInfo = UpdateComputerInfo;
            serverProgram.SetStudentInfo = SetStudentInfo;
            serverProgram.SetLabelNumReadyStudent = SetLabelNumReadyStudent;
            timeRemain = Int32.Parse(txtWorkingTime.Text.Trim()) * 60;
            grpTimeRemain.Visible = false;
            btnDisconnect.Enabled = false;
            btnStartExam.Enabled = false;
            btnActiveAllClient.Enabled = false;
            lblTotalStudent.Text = "Chưa chọn\ndanh sách";
            lblReadyStudent.Text = "Sinh viên";
        }

        // ==================================================== EVENT ======================================================

        private void btnStartExam_Click(object sender, EventArgs e)
        {
            var subjectInfo = new SubjectInformation();
            subjectInfo.ClientPath = txtClientPath.Text.ToString().Trim();
            subjectInfo.SubjectName = txtSubjectName.Text.ToString().Trim();
            subjectInfo.WorkingTime = Int32.Parse(txtWorkingTime.Text.ToString().Trim());
            var listExamPath = lstExams.Items.Cast<string>().ToList();
            btnDisableComputerNotConnect.PerformClick();

            if (listExamPath.Count < 1)
            {
                MessageBox.Show("Chưa chọn đề thi!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (listExamPath.Count > 1)
            {
                serverProgram.StartExam_MultiExam(listExamPath, subjectInfo);
                ControlEventWhenStartExam();
            }
            else
            {
                serverProgram.StartExam_SingleExam(listExamPath[0], subjectInfo);
                ControlEventWhenStartExam();
            }
        }

        private void btnSelectServerPath_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    txtServerPath.Text = folderBrowserDialog.SelectedPath + @"\";
                    serverProgram.ServerPath = txtServerPath.Text;

                    ShowPopupNotify("Thêm đề thi thành công!");
                }
            }
        }

        private void btnSelectClientPath_Click(object sender, EventArgs e)
        {
            using (var folderBrowserDialog = new FolderBrowserDialog())
            {
                DialogResult result = folderBrowserDialog.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowserDialog.SelectedPath))
                {
                    txtClientPath.Text = folderBrowserDialog.SelectedPath + @"\";

                    ShowPopupNotify("Thêm đề thi thành công!");
                }
            }
        }

        private void btnAddExam_Click(object sender, EventArgs e)
        {
            using (var fileDialog = new OpenFileDialog())
            {
                fileDialog.Multiselect = true;
                DialogResult result = fileDialog.ShowDialog();

                if (result == DialogResult.OK && fileDialog.FileNames.Length > 0)
                {
                    foreach (var item in fileDialog.FileNames)
                    {
                        if (!lstExams.Items.Contains(item))
                        {
                            lstExams.Items.Add(item);
                            ReadWrite.WriteNewExam_ToFile(item);
                        }
                    }

                    ShowPopupNotify("Thêm đề thi thành công!");
                }
            }
        }

        private void btnRemoveExam_Click(object sender, EventArgs e)
        {
            int index = lstExams.SelectedIndex;
            if (index != -1)
            {
                lstExams.Items.RemoveAt(index);
                var listExam = new List<string>();
                foreach (var item in lstExams.Items)
                {
                    listExam.Add(item.ToString());
                }
                ReadWrite.WriteListExam_ToFile(listExam);
            }

            ShowPopupNotify("Thêm đề thi thành công!");
        }

        private void btnAcceptSubjectInfo_Click(object sender, EventArgs e)
        {
            SetSubjectInfo_ToServerProgram();

            serverProgram.SendSubjectInfo();
            string textData = serverProgram.SubjectInfo.SubjectName + "|" + serverProgram.SubjectInfo.WorkingTime;
            ReadWrite.WriteText_ToFile("SubjectInfo.txt", textData);

            timeRemain = Int32.Parse(txtWorkingTime.Text.Trim()) * 60;
            ShowPopupNotify("❤ Thành công ❤");
        }

        private void btnSetIPRange_Click(object sender, EventArgs e)
        {
            FrmSetIP frmSetIP = new FrmSetIP();
            frmSetIP.RenderListComputer = RenderListComputer;

            var dialogResult = frmSetIP.ShowDialog();

            if(dialogResult == DialogResult.OK)
            {
                btnDisconnect.Enabled = true;
                btnSetIPRange.Enabled = false;
            }
        }

        private void btnDisableComputerNotConnect_Click(object sender, EventArgs e)
        {
            serverProgram.ListComputer.ForEach(computer =>
            {
                if(computer.ComputerInfo.ConnectState == CONNECTION_STATE.NOT_CONNECT)
                {
                    computer.ComputerInfo.ConnectState = CONNECTION_STATE.DISABLE;
                    computer.UpdateInfo();
                }
            });
        }

        private void tmrServer_Tick(object sender, EventArgs e)
        {
            if (timeRemain != -1)
            {
                int minute, second;
                string secondStr;

                timeRemain--;

                minute = timeRemain / 60;
                second = timeRemain - minute * 60;


                if (minute > 0)
                {
                    secondStr = (second.ToString().Length == 1) ? "0" + second : second.ToString();
                    lblTimeRemain.Text = minute + " phút " + secondStr + " giây";
                }
                else
                {
                    lblTimeRemain.Text = second + " giây";
                }

                if (timeRemain == 0)
                {
                    tmrServer.Enabled = false;
                    lblTimeRemain.Text = "Hết giờ làm bài";
                }
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            InitialStudentCallRoll();
            serverProgram.SendDisconnectRequestToAll();
        }

        private void btnGetListStudentFormCSVFile_Click(object sender, EventArgs e)
        {
            using (var fileDialog = new OpenFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls" })
            {
                DialogResult result = fileDialog.ShowDialog();

                if (result == DialogResult.OK && fileDialog.FileNames.Length > 0)
                {
                    GetListStudentInfo_FromExcel(fileDialog.FileName);

                    ShowPopupNotify("Đã lấy và gửi đi danh sách dự thi");
                    btnActiveAllClient.Enabled = true;
                    btnGetListStudentFormCSVFile.BackColor = SystemColors.ActiveCaption;
                    btnGetListStudentFormDatabase.BackColor = SystemColors.Control;
                }
            }
        }

        private void btnActiveAllClient_Click(object sender, EventArgs e)
        {
            serverProgram.SendActiveRequestToAll();
            btnStartExam.Enabled = true;
        }

        private void btnSendMessageToAll_Click(object sender, EventArgs e)
        {
            FrmSendMessage form = new FrmSendMessage(SendMessageToAll);
            var resultDialog = form.ShowDialog();

            if(resultDialog == DialogResult.OK)
            {
                ShowPopupNotify("Đã gửi thông điệp cho mọi người!");
            }
        }

        private void btnGetListStudentFormDatabase_Click(object sender, EventArgs e)
        {
            FrmGetStudentInfo form = new FrmGetStudentInfo();

            var resultDialog = form.ShowDialog();

            if (resultDialog == DialogResult.OK)
            {
                serverProgram.ListStudentInfo = form.GetListStudentInfo();
                serverProgram.SendStudentInfo();

                btnActiveAllClient.Enabled = true;
                btnGetListStudentFormCSVFile.BackColor = SystemColors.Control;
                btnGetListStudentFormDatabase.BackColor = SystemColors.ActiveCaption;
                InitialStudentCallRoll();
                ShowPopupNotify("Đã lấy và gửi đi danh sách dự thi");
            }
        }

        private void btnShutDownAll_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Tắt máy tất cả học sinh", "Chắc chắn không?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(dialogResult == DialogResult.OK)
            {
                serverProgram.SendShutDownRequestToAll();
            }
        }
        private void btnRestartAll_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Khởi động lại máy tất cả học sinh", "Chắc chắn không?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.OK)
            {
                serverProgram.SendRestartRequestToAll();
            }
        }

        private void FrmServer_FormClosing(object sender, FormClosingEventArgs e)
        {
            serverProgram.SendDisconnectRequestToAll();
        }

        private void btnMakeRollCall_Click(object sender, EventArgs e)
        {
            var listStudentInfo = serverProgram.ListStudentInfo;
            var listComputerInfo = serverProgram.ListComputer;

            FrmCallRoll form = new FrmCallRoll(listStudentInfo, listComputerInfo);

            form.ShowDialog();
        }

        private void btnPreventApplication_Click(object sender, EventArgs e)
        {
            FrmPreventRunApplication form = new FrmPreventRunApplication(SendListBlockingApplicationToAll);

            form.ShowDialog();
        }
    }
}
