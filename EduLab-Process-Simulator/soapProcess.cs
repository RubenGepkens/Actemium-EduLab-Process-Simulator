﻿/* EduLab-Proces-Sumulator - <<<< FILENAME >>>>
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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace EduLab_Process_Simulator
{
    /// <summary>
    /// Sequencer for the production of a batch of soap.
    /// </summary>
    public class soapProcess : batchControl
    {        
        private BATCH_STATE batchState = BATCH_STATE.None;
        private BATCH_TRANSITION batchTransition = BATCH_TRANSITION.BUSY;

        public float fltPLACEHOLDER_LT02 = 0.0F;
        public bool blnPLACEHOLDER_CV02 = false;
     
        // frmMain object, used for the invoke delegate to update the UI elements.
        private frmMain frmMain;

        // Simulation objects
        private Tank TA01 = new Tank("TA01", 1250, 1250, 10, 10);
        private Tank TA02 = new Tank("TA02", 50, 0, 10.23F, 3.34F);
        private Tank TA03 = new Tank("TA03", 125, 0, 2.23F, 3.34F);
        private Tank TA04 = new Tank("TA04", 50, 0, 2.23F, 3.34F);


        private ControlValve CV02 = new ControlValve("CV02");
        private ControlValve CV04 = new ControlValve("CV04");

        private SolenoidValve SV01 = new SolenoidValve("SV01");
        private SolenoidValve SV05B = new SolenoidValve("SV05B");
        private SolenoidValve SV10 = new SolenoidValve("SV10");
        private SolenoidValve SV11 = new SolenoidValve("SV11");
        private SolenoidValve SV40 = new SolenoidValve("SV40");        
        private SolenoidValve SV50 = new SolenoidValve("SB50");
        private SolenoidValve SV51 = new SolenoidValve("SV51");

        private Leveltransmitter LT02;
        private Leveltransmitter LT03;
        private Leveltransmitter LT04;

        private PressureTransmitter PT02;
        

        // Simulation speed related variables.
        private int intThreadTime = 1000;
        private readonly int intDefaultThreadTime = 1000;

        /// <summary>
        /// Create a simulation object using default parameters.
        /// </summary>
        public soapProcess()
        {
            // Since a default constructor was used to create a simulation object, use default parameters.
            intThreadTime = intDefaultThreadTime;
        }

        /// <summary>
        /// Allow the simulation acceleration to be set using this constructor.
        /// </summary>
        /// <param name="simulationAcceleration"></param>
        public soapProcess(int simulationAcceleration)
        {
            if ( simulationAcceleration < 1 || simulationAcceleration > 16)
            {
                // If the requested simulation speed is out of bounds, set the default threadtime.
                intThreadTime = intDefaultThreadTime;
            } else
            {
                // Calculate the threadtime for the requested acceleration speed.
                float fltTemp = 1000 / simulationAcceleration;
                intThreadTime = (int)Math.Round(fltTemp, 0);
                Console.WriteLine("Simulation acceleration {0}x with cycle time {1} ms", simulationAcceleration, intThreadTime);
            }
        }

        /// <summary>
        /// Starts the sequence of producing a batch of soap.
        /// </summary>
        public void startBatch(frmMain I_frmMain)
        {
            frmMain = I_frmMain;

            while (batchState != BATCH_STATE.Done)
            {
                updateBatchStatus();
                updateUI();
                Console.WriteLine("{0}\t {1}\t {2}\t {3}\t", batchState, batchTransition, TA02.getStatus().ToString(), CV02.getStatus().ToString());
                System.Threading.Thread.Sleep(intThreadTime);
            }
        }

        /// <summary>
        /// Updates the batchState.
        /// </summary>
        void updateBatchStatus()
        {
            switch (batchState)
            {
                case BATCH_STATE.None:
                    batchTransition = BATCH_TRANSITION.COMPLETE;
                    batchState = statusNone(batchTransition);
                    break;
                case BATCH_STATE.ALG_DOSEER_TA02:
                    batchTransition = ALG_DOSEER_TA02();
                    batchState = statusALG_DOSEER_TA02(batchTransition);
                    break;
                case BATCH_STATE.ALG_DOSEER_TA03:
                    batchTransition = ALG_DOSEER_TA03();
                    batchState = statusALG_DOSEER_TA03(batchTransition);
                    break;
                case BATCH_STATE.ALG_DOSEER_TA04:
                    batchTransition = ALG_DOSEER_TA04();
                    batchState = statusALG_DOSEER_TA04(batchTransition);
                    break;
                case BATCH_STATE.ALG_FILL_KE01:
                    batchTransition = ALG_FILL_KE01();
                    batchState = statusALG_FILL_KE01(batchTransition);
                    break;
                case BATCH_STATE.ALG_ACCEPT_LIQUID_KE01:
                    batchTransition = ALG_ACCEPT_LIQUID_KE01();
                    batchState = statusALG_ACCEPT_LIQUID_KE01(batchTransition);
                    break;
                case BATCH_STATE.ALG_MIX_KE01:
                    batchTransition = ALG_MIX_KE01();
                    batchState = statusALG_MIX_KE01(batchTransition);
                    break;
                case BATCH_STATE.ALG_EMPTY_KE01:
                    batchState = statusALG_EMPTY_KE01(batchTransition);
                    break;
                case BATCH_STATE.Done:
                    batchState = statusDone(batchTransition);
                    break;
                default:
                    break;
            }            
        }

        /// <summary>
        /// Updates the frmMain with the actual simulation values.
        /// </summary>
        public void updateUI()
        {
            frmMain.updateTextBox( batchState.ToString(),
                                   TA02.getStatus().ToString()
            );
        }

        public BATCH_TRANSITION ALG_DOSEER_TA02()
        {
            // If CV is closed, open it.
            if (CV02.isClosed())
            {
                CV02.openValve();
            }

            // If CV is opened, simulate inflow of fluid.
            if ( CV02.isOpen())
            {
                TA02.fillTank();
            }       

            // Operation is complete when tank is filled.
            if ( TA02.getStatus() >= 50F)
            {
                return BATCH_TRANSITION.COMPLETE;
            }
            else
            {
                return BATCH_TRANSITION.BUSY;
            }
        }

        public BATCH_TRANSITION ALG_DOSEER_TA03()
        {            
            return BATCH_TRANSITION.COMPLETE;
        }

        public BATCH_TRANSITION ALG_DOSEER_TA04()
        {
            return BATCH_TRANSITION.COMPLETE;
        }

        public BATCH_TRANSITION ALG_FILL_KE01()
        {
            return BATCH_TRANSITION.COMPLETE;
        }

        public BATCH_TRANSITION ALG_ACCEPT_LIQUID_KE01()
        {
            return BATCH_TRANSITION.COMPLETE;
        }

        public BATCH_TRANSITION ALG_MIX_KE01()
        {
            return BATCH_TRANSITION.COMPLETE;
        }

        public BATCH_TRANSITION ALG_EMPTY_KE01()
        {
            return BATCH_TRANSITION.COMPLETE;
        }
    }
}