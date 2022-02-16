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
    public partial class FrmPreventRunApplication : Form
    {
        private Action<List<string>> SendListBlockingApplicationToAll;
        private string filename = "ListApplicationPrevent.txt";

        private void GetListPreventApp()
        {
            List<string> listApplication = ReadWrite.ReadText_FromFile_ToListString(filename);

            if (listApplication != null)
            {
                listApplication.ForEach(application =>
                {
                    lstBlockingApplication.Items.Add(application);
                });
            }
        }

        public FrmPreventRunApplication(Action<List<string>> SendListBlockingApplicationToAll)
        {
            InitializeComponent();
            this.SendListBlockingApplicationToAll = SendListBlockingApplicationToAll;
        }

        private void FrmPreventRunApplication_Load(object sender, EventArgs e)
        {
            GetListPreventApp();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string appName = txtApplicationName.Text.Trim();
            if (appName != "")
            {
                txtApplicationName.Text = "";
                lstBlockingApplication.Items.Add(appName);

                var listApplication = lstBlockingApplication.Items.Cast<string>().ToList();
                ReadWrite.WriteText_FromListString_ToFile(filename, listApplication);
                SendListBlockingApplicationToAll(listApplication);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = lstBlockingApplication.SelectedIndex;
            if (index != -1)
            {
                lstBlockingApplication.SelectedItem = -1;
                lstBlockingApplication.Items.RemoveAt(index);

                var listApplication = lstBlockingApplication.Items.Cast<string>().ToList();
                ReadWrite.WriteText_FromListString_ToFile(filename, listApplication);
                SendListBlockingApplicationToAll(listApplication);
            }
        }
    }
}
