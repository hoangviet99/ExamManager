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
    public partial class FrmSendMessage : Form
    {
        Action<string> SendMessaageToAll;

        public FrmSendMessage(Action<string> sendMessaageToAll_Function)
        {
            InitializeComponent();
            txtMessage.Text = "";
            SendMessaageToAll = sendMessaageToAll_Function;
        }

        private void btnSent_Click(object sender, EventArgs e)
        {
            string message = txtMessage.Text.Trim();

            if(message != "")
            {
                SendMessaageToAll(message);
            }

            Close();
        }
    }
}
