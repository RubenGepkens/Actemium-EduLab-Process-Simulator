/* EduLab-Proces-Sumulator - <<<< FILENAME >>>>
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

        public SolenoidValve SV20 = new SolenoidValve();

        private frmMain frmMain;

        public soapProcess()
        {
            
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
                Console.WriteLine("{0}\t {1}\t {2}\t {3}\t", batchState, batchTransition, fltPLACEHOLDER_LT02, blnPLACEHOLDER_CV02);
                System.Threading.Thread.Sleep(1000);
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

        public void updateUI()
        {
            frmMain.updateTextBox( batchState.ToString(),
                                   fltPLACEHOLDER_LT02.ToString()
            );
        }

        public BATCH_TRANSITION ALG_DOSEER_TA02()
        {
            // If CV is closed, open it.
            if (blnPLACEHOLDER_CV02 == false)
            {
                blnPLACEHOLDER_CV02 = true;                
            }

            // If CV is opened, simulate inflow of fluid.
            if (blnPLACEHOLDER_CV02 == true)
            {
                fltPLACEHOLDER_LT02 += 10.23F;
            }

            // Operation is complete when tank is filled.
            if (fltPLACEHOLDER_LT02 >= 50)
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
            Console.WriteLine(SV20.svValveStatus);
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