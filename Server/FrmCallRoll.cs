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
    public partial class FrmCallRoll : Form
    {
        private List<StudentInformation> listStudentInfo;
        private List<uc_Computer> listComputerInfo;

        private void MakeCallRoll()
        {
            int totalStudent = listStudentInfo.Count();
            int presentStudent = 0;
            int absentStudent = 0;

            lstStudentInfo.Items.Clear();

            listStudentInfo.ForEach(studentInfo =>
            {
                var computerInfo = listComputerInfo.Find(x => (x.StudentInfo.StudentID == studentInfo.StudentID) && (x.ComputerInfo.ConnectState == CONNECTION_STATE.READY));

                if(computerInfo != null)
                {
                    ListViewItem item = new ListViewItem(studentInfo.StudentID);
                    item.SubItems.Add(studentInfo.StudentName);
                    item.SubItems.Add(studentInfo.ClassName);
                    item.SubItems.Add("Có mặt");

                    presentStudent++;
                    item.BackColor = Color.FromArgb(128, 255, 128);
                    lstStudentInfo.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(studentInfo.StudentID);
                    item.SubItems.Add(studentInfo.StudentName);
                    item.SubItems.Add(studentInfo.ClassName);
                    item.SubItems.Add("Vắng mặt");

                    absentStudent++;
                    item.BackColor = Color.FromArgb(232, 78, 78);
                    lstStudentInfo.Items.Add(item);
                }
            });

            lblTotalStudent.Text += totalStudent.ToString();
            lblPresentStudent.Text += presentStudent.ToString();
            lblAbsentStudent.Text += absentStudent.ToString();
        }

        public FrmCallRoll(List<StudentInformation> listStudentInfo, List<uc_Computer> listComputerInfo)
        {
            InitializeComponent();
            this.listStudentInfo = listStudentInfo;
            this.listComputerInfo = listComputerInfo;
        }

        private void FrmCallRoll_Load(object sender, EventArgs e)
        {
            MakeCallRoll();
        }
    }
}
