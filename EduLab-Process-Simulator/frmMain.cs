using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EduLab_Process_Simulator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void overDezeApplicatieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmAboutbox = new frmAboutBox();
            frmAboutbox.Show();
        }

        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
