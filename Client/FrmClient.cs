using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Server;

namespace Client
{
    public partial class frmClient : Form
    {
        ClientProgram clientProgram;
        const int TIME_TO_WARING = 10;
        int timeRemain = -1;
        int timeWarningRemain = -1;
        bool isLastWarning = false;

        // ================================================== METHOD =====================================================
        private void SetSubjectInformation(SubjectInformation subjectInfo, bool isStartExam)
        {
            if(subjectInfo == null)
            {
                return;
            }

            lblSubjectName.Text = subjectInfo.SubjectName;
            lblWorkingTime.Text = subjectInfo.WorkingTime + " phút";

            if (isStartExam)
            {
                llbExamTitle.Text = subjectInfo.ClientPath + subjectInfo.ExamTitle;
                lblNote.Text = "Lưu ý SV lưu bài làm tại đường dẫn: " + subjectInfo.ClientPath;
                btnAccept.Enabled = false;
                btnSubmit.Enabled = true;
                cmbListStudentInfo.Enabled = false;
                timeRemain = subjectInfo.WorkingTime * 60;
                timeWarningRemain = TIME_TO_WARING * 60;
            }
        }

        private void SetListStudentInfo(List<StudentInformation> listStudentInfo)
        {
            if (listStudentInfo == null) return;

            cmbListStudentInfo.DataSource = listStudentInfo;
            cmbListStudentInfo.DisplayMember = "StudentName";
            cmbListStudentInfo.ValueMember = "StudentID";

            cmbListStudentInfo.SelectedIndex = -1;
            grpStudentInfo.Visible = true;
            grpStudentInfoChoice.Visible = true;
        }

        private void SetMessage(string message)
        {
            if (message.Equals("/--[DenyToConnect]--/"))
            {
                Text = "Client - Bị từ chối truy cập";
                MessageBox.Show(new Form { TopMost = true }, "Không nằm trong dãy địa chỉ IP được phép truy cập!\nHoặc bị từ chối truy cập", "Từ chối", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show(new Form { TopMost = true }, message, "Thông điệp nhận được", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ActiveAllControl()
        {
            cmbListStudentInfo.Enabled = true;
            btnAccept.Enabled = true;
        }

        private void ExitProgram()
        {
            Environment.Exit(0);
        }

        private void InitClientProgram()
        {
            string serverIpStr = txtServerIP.Text.Trim();
            int port = 9999;

            IPAddress serverIP;
            if(serverIpStr.Equals("localhost", StringComparison.OrdinalIgnoreCase) || serverIpStr.Equals("loopback", StringComparison.OrdinalIgnoreCase))
            {
                serverIP = IPAddress.Loopback;
            }
            else
            {
                serverIP = IPAddress.Parse(serverIpStr);
            }

            clientProgram = new ClientProgram(serverIP, port);
            clientProgram.SetSubjectInfo = SetSubjectInformation;
            clientProgram.SetListStudentInfo = SetListStudentInfo;
            clientProgram.ShowPopupWarning = ShowPopupWarning;
            clientProgram.ExitProgram = ExitProgram;
            clientProgram.ActiveAllControl = ActiveAllControl;
            clientProgram.SetMessage = SetMessage;
        }

        private void SubmitExam()
        {
            string studentNameASCII = ConvertToASCII.ConvertStringToASCII(lblStudentName.Text);
            string submitFileName = lblStudentID.Text + "_" + studentNameASCII;
            btnSubmit.Enabled = false;

            clientProgram.SubmitExam(llbExamTitle.Text, submitFileName);
        }

        private void ShowPopupWarning(string notification)
        {
            var form = new FrmWarning(notification);
            form.TopMost = true;
            Task.Delay(TimeSpan.FromSeconds(7)).ContinueWith((t) => form.Close(), TaskScheduler.FromCurrentSynchronizationContext());

            form.Show();
        }

        // ================================================== FORM LOAD =====================================================
        public frmClient()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            cmbListStudentInfo.Enabled = false;
            btnAccept.Enabled = false;
            grpStudentInfo.Visible = false;
            grpStudentInfoChoice.Visible = false;
            lblNote.Text = "";
            btnSubmit.Enabled = false;
        }

        // ===================================================== EVENT ======================================================
        private void btnConnect_Click(object sender, EventArgs e)
        {
            InitClientProgram();
            btnConnect.Enabled = false;
            txtServerIP.Enabled = false;

            if (clientProgram.Connect())
            {
                this.Text = "Client - Đã kết nối";
                //MessageBox.Show("Kết nối thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                btnConnect.Enabled = true;
                txtServerIP.Enabled = true;
                this.Text = "Client - Lỗi kết nối";
            }
        }

        private void frmClient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(clientProgram != null)
            {
                clientProgram.Close();
            }
        }

        private void tmrTimeRemain_Tick(object sender, EventArgs e)
        {
            if (timeRemain != -1)
            {
                tmrTimeRemain.Interval = FrmServer.INTERVAL;

                int minute, second;
                string secondStr;

                timeRemain--;
                timeWarningRemain--;

                minute = timeRemain / 60;
                second = timeRemain - minute * 60;


                if(minute > 0)
                {
                    secondStr = (second.ToString().Length == 1) ? "0" + second : second.ToString();
                    lblTimeRemain.Text = minute + " phút " + secondStr + " giây";
                }
                else
                {
                    lblTimeRemain.Text = second + " giây";
                }

                if(timeWarningRemain < 1)
                {
                    timeWarningRemain = TIME_TO_WARING * 60;
                    ShowPopupWarning("Thời gian còn lại: " + minute + " phút!");
                }

                if(timeRemain == 300 && !isLastWarning)
                {
                    isLastWarning = true;
                    MessageBox.Show(new Form { TopMost = true }, "Còn 5 phút, sinh viên canh thời gian nộp bài", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                if(timeRemain == 0)
                {
                    tmrTimeRemain.Enabled = false;
                    lblTimeRemain.ForeColor = Color.DarkRed;
                    lblTimeRemain.Text = "Hết giờ làm bài";
                    ShowPopupWarning("Hết giờ làm bài");
                    SubmitExam();
                }
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (cmbListStudentInfo.SelectedIndex == -1)
            {
                lblStudentName.Text = "Chưa chọn";
                lblStudentID.Text = "Chưa chọn";
                return;
            }
            var studentInfo = (StudentInformation)cmbListStudentInfo.SelectedItem;
            if (studentInfo != null)
            {
                clientProgram.SendStudentInfo(studentInfo);

                lblStudentName.Text = studentInfo.StudentName;
                lblStudentID.Text = studentInfo.StudentID;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SubmitExam();
            btnSubmit.Enabled = false;
            tmrTimeRemain.Enabled = false;
            lblNote.Text = "Đã nộp bài";
        }

        private void llbExamTitle_Click(object sender, EventArgs e)
        {
            if (llbExamTitle.Text.Contains(":"))
            {
                CMD.OpenFile(llbExamTitle.Text);
            }
        }
    }
}