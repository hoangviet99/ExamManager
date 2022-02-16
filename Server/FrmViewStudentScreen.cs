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
    public partial class FrmViewStudentScreen : Form
    {
        public ComputerInformation ComputerInfo { get; set; }

        public void SetStudentScreenDisplay(Image screenDisplay)
        {
            picStudentScreen.Image = screenDisplay;
        }

        public FrmViewStudentScreen()
        {
            InitializeComponent();
        }

        private void FrmViewStudentScreen_Load(object sender, EventArgs e)
        {
            this.Text += " [máy " + ComputerInfo.Username + "]";
        }
    }
}
