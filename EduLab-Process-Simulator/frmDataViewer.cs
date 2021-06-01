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
    public partial class frmDataViewer : Form
    {
        private DataTable dataTable;

        public frmDataViewer(DataTable dataTable)
        {
            this.dataTable = dataTable;
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void DataViewer_Shown(object sender, EventArgs e)
        {
            dataGridView.DataSource = dataTable;
            dataGridView.AutoResizeColumns();
        }

        private void btnMnuClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
