/* EduLab-Proces-Sumulator - frmDataViewer.cs
 * 
 * Simulator for the process installation of the EduLab. Made for Actemium in Veghel, The Netherlands.
 * 
 * Copyright (c) 2021 Ruben Gepkens & Maurits Duel
 * 
 * This software is distributed using the MIT License.
 * For terms of use read the LICENSE.md document included in this repository or visit: www.mit-license.org.
 * 
 * Icons used in this project are taken from the GNOME desktop project ('gnome-icon-theme 2.20.0') released under the GNU GPLv2 license. 
 * 
 */
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

        private void Export()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Title = "Selecteer een locatie om de gegevens te exporteren..";
            saveFileDialog.DefaultExt = "csv";
            saveFileDialog.Filter = "Comma-separated values (*.csv)|*.csv|Textbestand (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string strFileName = saveFileDialog.FileName;
                                
                MessageBox.Show("" + strFileName, ">:-(");

                dataTable.ToCSV(strFileName);

            }

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

        private void btnExportData_Click(object sender, EventArgs e)
        {
            Export();
        }
    }
}
