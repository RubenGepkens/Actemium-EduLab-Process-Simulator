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
        // List for the maximum acceleration of the simulation.
        private List<int> lstSimulationAcceleration = new List<int> { 1, 2, 4, 8, 16 };

        // Global thread variable
        Thread simulationThread;

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
            
            //Thread thread = new Thread(() => zeepProcess.startBatch(this));
            //thread.Start();

            simulationThread = new Thread(() => zeepProcess.startBatch(this));
            simulationThread.Start();
        }

        /// <summary>
        /// Invoke method to update the UI of frmMain from the running simulation thread.
        /// </summary>
        /// <param name="strBatchStatus"></param>
        /// <param name="strLT02"></param>
        public void updateTextBox(  string strBatchStatus,
                                    string strLT02,
                                    string strLT03,
                                    string strLT04,
                                    string strKE01,

                                    string strCV02,
                                    string strCV03,
                                    string strCV04,

                                    string strSV01,
                                    string strSV05A,
                                    string strSV05B,
                                    string strSV10,
                                    string strSV12,
                                    string strSV21,
                                    string strSV22,
                                    string strSV31,                                    
                                    string strSV40,
                                    string strSV41,
                                    string strSV50,
                                    string strSV51
            )
        {
            Invoke((MethodInvoker)delegate
            {
                txtBatchStatus.Text = strBatchStatus;
                txtLT02.Text = strLT02;
                txtLT03.Text = strLT03;
                txtLT04.Text = strLT04;
                txtKE01.Text = strKE01;

                //txtCV02.Text = strCV02;
                //txtCV03.Text = strCV03;
                //txtCV04.Text = strCV04;

                UpdateValveStatus(txtCV02, strCV02);
                UpdateValveStatus(txtCV03, strCV03);
                UpdateValveStatus(txtCV04, strCV04);

                //txtSV01.Text = strSV01;
                //txtSV05A.Text = strSV05A;
                //txtSV05B.Text = strSV05B;
                //txtSV10.Text = strSV10;                
                //txtSV12.Text = strSV12;
                //txtSV21.Text = strSV21;
                //txtSV22.Text = strSV22;
                //txtSV31.Text = strSV31;                
                //txtSV40.Text = strSV40;
                //txtSV41.Text = strSV41;
                //txtSV50.Text = strSV50;
                //txtSV51.Text = strSV51;

                UpdateValveStatus(txtSV01, strSV01);
                UpdateValveStatus(txtSV05A, strSV05A);
                UpdateValveStatus(txtSV05B, strSV05B);
                UpdateValveStatus(txtSV10, strSV10);
                UpdateValveStatus(txtSV12, strSV12);
                UpdateValveStatus(txtSV21, strSV21);
                UpdateValveStatus(txtSV22, strSV22);
                UpdateValveStatus(txtSV31, strSV31);
                UpdateValveStatus(txtSV40, strSV40);
                UpdateValveStatus(txtSV41, strSV41);
                UpdateValveStatus(txtSV50, strSV50);
                UpdateValveStatus(txtSV51, strSV51);

            });
        }

        private void UpdateValveStatus(TextBox textBox, string status)
        {
            // Default background color is "Info".
            Color colorOpen             = Color.LightGreen;
            Color colorClosed           = SystemColors.Info;

            if (status == "True")
            {
                textBox.Text = "Open";
                textBox.BackColor = colorOpen;

            } else if (status == "False")
            {
                textBox.Text = "Closed";
                textBox.BackColor = colorClosed;
            }

            if (status == "100")
            {
                textBox.Text = status + "%";
                textBox.BackColor = colorOpen;
            } else if (status == "0")
            {
                textBox.Text = status + "%";
                textBox.BackColor = colorClosed;
            }
        }

        // =========================================================================================================================================================

        private void btnStart_Click(object sender, EventArgs e)
        {
            simulateProcess();
        }

        private void btnPauze_Click(object sender, EventArgs e)
        {
            
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (simulationThread.IsAlive)
            {
                simulationThread.Abort();
            }
        }

        private void btnStartFast_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ( simulationThread.IsAlive ) 
            {
                simulationThread.Abort();
            }            
        }
    }
}