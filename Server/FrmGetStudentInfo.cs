using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class FrmGetStudentInfo : Form
    {
        private List<ClassInformation> listClass = new List<ClassInformation>();
        private List<StudentInformation> listStudent = new List<StudentInformation>();

        private void GetListClass()
        {
            lstClassInfo.Items.Clear();
            listClass = SQLConnect.GetListClassInfo_FromDatabase();
            listClass.ForEach(classInfo =>
            {
                lstClassInfo.Items.Add(classInfo.ClassName);
            });
        }

        private void GetListStudent(string className)
        {
            lstStudentInfo.Items.Clear();
            listStudent = SQLConnect.GetListStudentInfo_FromDatabase(className);
            listStudent.ForEach(studentInfo =>
            {
                ListViewItem item = new ListViewItem(studentInfo.StudentID);
                item.SubItems.Add(studentInfo.StudentName);
                item.SubItems.Add(studentInfo.ClassName);

                lstStudentInfo.Items.Add(item);
            });
        }

        public FrmGetStudentInfo()
        {
            InitializeComponent();
        }

        private void FrmGetStudentInfo_Load(object sender, EventArgs e)
        {
            GetListClass();
        }

        private void lstClassInfo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lstClassInfo.SelectedItems.Count > 0)
            {
                ListViewItem item = lstClassInfo.SelectedItems[0];
                string className = item.Text;
                GetListStudent(className);
            }
        }

        public List<StudentInformation> GetListStudentInfo()
        {
            return listStudent;
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lstClassInfo.SelectedItems.Count < 1)
            {
                MessageBox.Show("Vui lòng chọn lớp bạn muốn", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (btnSelect.DialogResult == DialogResult.OK) return;
                btnSelect.DialogResult = DialogResult.OK;
                btnSelect.PerformClick();
            }
        }
    }
}
