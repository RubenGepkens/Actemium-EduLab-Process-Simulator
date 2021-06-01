﻿/* EduLab-Proces-Sumulator - frmMain
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
        private readonly List<int> lstSimulationAcceleration = new List<int> { 1, 2, 4, 8, 16 };

        // Global thread variable
        Thread simulationThread;

        private SimulationRecorder simulationRecorder;

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
            simulationRecorder = new SimulationRecorder(zeepProcess);

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
        public void UpdateUI(  string strBatchStatus,
                                    Tank TA01,
                                    Leveltransmitter LT02,
                                    Leveltransmitter LT03,
                                    Leveltransmitter LT04,
                                    Tank KE01,

                                    ControlValve CV02,
                                    ControlValve CV03,
                                    ControlValve CV04,

                                    SolenoidValve SV01,
                                    SolenoidValve SV05A,
                                    SolenoidValve SV05B,
                                    SolenoidValve SV10,
                                    SolenoidValve SV12,
                                    SolenoidValve SV21,
                                    SolenoidValve SV22,
                                    SolenoidValve SV31,
                                    SolenoidValve SV40,
                                    SolenoidValve SV41,
                                    SolenoidValve SV50,
                                    SolenoidValve SV51,

                                    Pump PO01,
                                    Pump PO02,
                                    Pump PO03,
                                    Pump PO04,
                                    Pump PO05
            )
        {
            Invoke((MethodInvoker)delegate
            {
                txtBatchStatus.Text = strBatchStatus;

                txtTA01.Text = Math.Round(TA01.GetVolume(), 1).ToString();
                txtLT02.Text = Math.Round(LT02.GetLevel(), 1).ToString();
                txtLT03.Text = Math.Round(LT03.GetLevel(), 1).ToString();
                txtLT04.Text = Math.Round(LT04.GetLevel(), 1).ToString();
                txtKE01.Text = Math.Round(KE01.GetVolume(), 1).ToString();

                UpdateControlValveStatus(txtCV02, CV02);
                UpdateControlValveStatus(txtCV03, CV03);
                UpdateControlValveStatus(txtCV04, CV04);

                UpdateSolenoidValveStatus(txtSV01, SV01);
                UpdateSolenoidValveStatus(txtSV05A, SV05A);
                UpdateSolenoidValveStatus(txtSV05B, SV05B);
                UpdateSolenoidValveStatus(txtSV10, SV10);
                UpdateSolenoidValveStatus(txtSV12, SV12);
                UpdateSolenoidValveStatus(txtSV21, SV21);
                UpdateSolenoidValveStatus(txtSV22, SV22);
                UpdateSolenoidValveStatus(txtSV31, SV31);
                UpdateSolenoidValveStatus(txtSV40, SV40);
                UpdateSolenoidValveStatus(txtSV41, SV41);
                UpdateSolenoidValveStatus(txtSV50, SV50);
                UpdateSolenoidValveStatus(txtSV51, SV51);

                UpdatePumpStatus(txtPO01, PO01);
                UpdatePumpStatus(txtPO02, PO02);
                UpdatePumpStatus(txtPO03, PO03);
                UpdatePumpStatus(txtPO04, PO04);
                UpdatePumpStatus(txtPO05, PO05);
            });
        }

        public void RecordData()
        {
            Invoke((MethodInvoker)delegate
            {
                simulationRecorder.RecordData();
            });
        }

        private void UpdateControlValveStatus(TextBox textBox, ControlValve controlValve)
        {
            // Default background color is "Info".
            Color colorOpen         = Color.LightGreen;
            Color colorClosed       = SystemColors.Info;

            if (controlValve.IsOpen())
            {
                textBox.Text = controlValve.GetStatus().ToString() + "%";
                textBox.BackColor = colorOpen;
            }
            else if (controlValve.IsClosed())
            {
                textBox.Text = controlValve.GetStatus().ToString() + "%";
                textBox.BackColor = colorClosed;
            }
        }

        private void UpdateSolenoidValveStatus(TextBox textBox, SolenoidValve solenoidValve)
        {
            // Default background color is "Info".
            Color colorOpen             = Color.LightGreen;
            Color colorClosed           = SystemColors.Info;

            if (solenoidValve.IsOpen())
            {
                textBox.Text = "Open";
                textBox.BackColor = colorOpen;

            } else if (solenoidValve.IsClosed())
            {
                textBox.Text = "Closed";
                textBox.BackColor = colorClosed;
            }
        }

        private void UpdatePumpStatus(TextBox textbox, Pump pump)
        {
            Color colorRunning = Color.LightGreen;
            Color colorStopped = Color.Yellow;

            if (pump.IsRunning())
            {
                textbox.Text = "Running";
                textbox.BackColor = colorRunning;
            } else
            {
                textbox.Text = "Stopped";
                textbox.BackColor = colorStopped;
            }
        }

        // =========================================================================================================================================================

        private void btnStart_Click(object sender, EventArgs e)
        {
            simulateProcess();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (simulationThread.IsAlive)
            {
                simulationThread.Abort();
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if ( simulationThread.IsAlive ) 
            {
                simulationThread.Abort();
            }            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("JA");
            simulationRecorder.DebugData();
        }
    }
}