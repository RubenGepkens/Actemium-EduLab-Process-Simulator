﻿/* EduLab-Proces-Sumulator - frmMain
 * 
 * Simulator for the process installation of the EduLab. Made for Actemium in Veghel, The Netherlands.
 * 
 * Copyright (c) 2021 Ruben Gepkens & Maurits Duel
 * 
 * This software is distributed using the MIT License.
 * For terms of use read the LICENSE.md document included in this repository or visit: www.mit-license.org.
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
    }
}
