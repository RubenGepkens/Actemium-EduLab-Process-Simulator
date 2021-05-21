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

        /// <summary>
        /// Start simulation of the process installation.
        /// </summary>
        void simulateProcess()
        {
            soapProcess zeepProcess = new soapProcess();
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

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            SolenoidValve SV51 = new SolenoidValve("SV51");
            SolenoidValve SV10 = new SolenoidValve("SV10");
            SolenoidValve SV11 = new SolenoidValve("SV11");
            
            
            SolenoidValve SV51 = new SolenoidValve();
            SolenoidValve SV10 = new SolenoidValve();
            SolenoidValve SV11 = new SolenoidValve();

            SV51.strNameTEST = "SV51";
            SV10.strNameTEST = "SV10";
            SV11.strNameTEST = "SV11";

            Console.WriteLine(SV51.strNameTEST);
            Console.WriteLine(SV51.getName() );
            */
        }

        private void btnStartBatch_Click(object sender, EventArgs e)
        {
            simulateProcess();
        }
    }
}