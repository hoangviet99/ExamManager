using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Server.Enums;

namespace Server
{
    public partial class uc_Computer : UserControl
    {
        public ComputerInformation ComputerInfo { get; set; }
        public StudentInformation StudentInfo { get; set; }

        private Action<ComputerInformation> RequestViewStudentScreen;

        public uc_Computer(Action<ComputerInformation> RequestViewStudentScreen)
        {
            InitializeComponent();
            ComputerInfo = new ComputerInformation();
            StudentInfo = new StudentInformation();

            this.BackColor = Color.Transparent;
            lblUsername.Parent = picComputer;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Text = "";

            this.RequestViewStudentScreen = RequestViewStudentScreen;
        }

        private void uc_Computer_Load(object sender, EventArgs e)
        {
            grpComputer.Text = "Chưa kết nối";
            lblComputerName.Text = ". . .";
            lblStudentID.Text = ". . .";
            lblStudentName.Text = ". . .";
            picComputer.Image = Image.FromFile(@"pics\computer1.png");
        }

        public void UpdateInfo()
        {
            if(ComputerInfo != null)
            {
                lblComputerName.Text = (ComputerInfo.ComputerName != null) ? ComputerInfo.ComputerName : ". . .";
                lblUsername.Text = (ComputerInfo.Username != null) ? ComputerInfo.Username : "";
            }
            if(StudentInfo != null)
            {
                lblStudentID.Text = (StudentInfo.StudentID != null) ? StudentInfo.StudentID : ". . .";
                lblStudentName.Text = (StudentInfo.StudentName != null) ? StudentInfo.StudentName : ". . .";
            }

            lblUsername.ForeColor = Color.Black;
            switch (ComputerInfo.ConnectState)
            {
                case CONNECTION_STATE.NOT_CONNECT:
                    picComputer.Image = Image.FromFile(@"pics\computer1.png");
                    grpComputer.Text = "Chưa kết nối";
                    break;
                case CONNECTION_STATE.CONNECTED:
                    picComputer.Image = Image.FromFile(@"pics\computer2.png");
                    grpComputer.Text = "Đã kết nối";
                    break;
                case CONNECTION_STATE.DISABLE:
                    picComputer.Image = Image.FromFile(@"pics\computer3.png");
                    grpComputer.Text = "Bị disable";
                    break;
                case CONNECTION_STATE.GONE:
                    lblUsername.ForeColor = Color.White;
                    picComputer.Image = Image.FromFile(@"pics\computer4.png");
                    grpComputer.Text = "Đã rời đi";
                    break;
                case CONNECTION_STATE.READY:
                    picComputer.Image = Image.FromFile(@"pics\computer5.png");
                    grpComputer.Text = "Đã sẵn sàng thi";
                    break;
                case CONNECTION_STATE.DOING:
                    picComputer.Image = Image.FromFile(@"pics\computer6.png");
                    grpComputer.Text = "Đang làm bài thi";
                    break;
            }
        }

        private void grpComputer_Click(object sender, EventArgs e)
        {
            if(ComputerInfo.ConnectState == CONNECTION_STATE.CONNECTED ||
                ComputerInfo.ConnectState == CONNECTION_STATE.READY ||
                ComputerInfo.ConnectState == CONNECTION_STATE.DOING)
            {
                var dialogResult = MessageBox.Show("Xem màn hình máy này", "Xem màn hình", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if(dialogResult == DialogResult.OK)
                {
                    RequestViewStudentScreen(ComputerInfo);
                    //FrmViewStudentScreen form = new FrmViewStudentScreen(RequestViewStudentScreen);
                    //form.ComputerInfo = ComputerInfo;

                    //form.Show();
                }
            }
        }
    }
}
