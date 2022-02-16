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
    public partial class FrmSetIP : Form
    {
        public Action<List<string>> RenderListComputer { get; set; }
        public FrmSetIP()
        {
            InitializeComponent();
        }

        private void FrmSetIP_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtStartIP;

            string textData = ReadWrite.ReadText_FromFile("IPRange.txt");

            if (textData != null && textData != "")
            {
                string[] ipInfo = textData.Split('|');
                txtStartIP.Text = ipInfo[0];
                txtLastIP.Text = ipInfo[1];
                txtSubnetMask.Text = ipInfo[2];
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string textData = txtStartIP.Text.Trim() + "|" + txtLastIP.Text.Trim() + "|" + txtSubnetMask.Text;
            ReadWrite.WriteText_ToFile("IPRange.txt", textData);

            IPInformation.FirstIP = txtStartIP.Text;
            IPInformation.LastIP = txtLastIP.Text;

            List<string> listIP = IPInformation.GetListIPInRange();

            RenderListComputer(listIP);

            this.Close();
        }
    }
}
