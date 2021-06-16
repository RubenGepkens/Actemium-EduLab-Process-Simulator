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
    public partial class frmSettings : Form
    {
        public DateTime dtSimulation { get; set; }

        public frmSettings()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

            dtSimulation = dtpSimulation.Value;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            if (dtSimulation > dtpSimulation.MinDate && dtSimulation < dtpSimulation.MaxDate)
            {
                dtpSimulation.Value = dtSimulation;
            } else
            {
                dtpSimulation.Value = DateTime.Now;
            }            
        }
    }
}
