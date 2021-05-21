/* EduLab-Proces-Sumulator - frmMain
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
using System.Threading;
using System.Windows.Forms;

namespace EduLab_Process_Simulator
{
    public partial class frmMain : Form
    {
        private List<int> lstSimulationAcceleration = new List<int> { 1, 2, 4, 8, 16 };

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            cbxSimulationAcceleration.SelectedIndex = 0;
        }

        private void overDezeApplicatieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmAboutbox = new frmAboutBox();
            frmAboutbox.Show();
        }

        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Start simulation of the process installation.
        /// </summary>
        void simulateProcess()
        {
            // Retrieve the simulation acceleration from a list using the combobox as index.
            int intSimulationAcceleration = lstSimulationAcceleration[cbxSimulationAcceleration.SelectedIndex];

            // Create new soapProces object and set the simulation speed.
            soapProcess zeepProcess = new soapProcess( intSimulationAcceleration );
            
            // Create new thread and using a lambda expression start the simulation.
            Thread thread = new Thread(() => zeepProcess.startBatch(this));
            thread.Start();
        }

        /// <summary>
        /// Invoke method to update the UI of frmMain from the running simulation thread.
        /// </summary>
        /// <param name="strBatchStatus"></param>
        /// <param name="strLT02"></param>
        public void updateTextBox(string strBatchStatus,
                                    string strLT02)
        {
            Invoke((MethodInvoker)delegate
            {
                txtLevelIndicator.Text = strBatchStatus;
                txtLT02.Text = strLT02;
            });
        }

        // =========================================================================================================================================================

        private void btnStartBatch_Click(object sender, EventArgs e)
        {
            simulateProcess();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            simulateProcess();
        }

        private void btnPauze_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Acceleration: {0}", lstSimulationAcceleration[cbxSimulationAcceleration.SelectedIndex] );
        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }

        private void btnStartFast_Click(object sender, EventArgs e)
        {

        }

    }
}