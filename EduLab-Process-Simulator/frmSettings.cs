/* EduLab-Proces-Sumulator - Tank.cs
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
