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

namespace EduLab_Process_Simulator
{
    /// <summary>
    /// Sequencer for the production of a batch of soap.
    /// </summary>
    public class soapProcess : batchControl
    {
        private bool blnInProduction = false;

        private BATCH_STATE batchState = BATCH_STATE.None;
        private BATCH_TRANSITION batchTransition = BATCH_TRANSITION.BUSY;

        public soapProcess()
        {

        }

        public void startBatch()
        {
            blnInProduction = true;

            while (blnInProduction == true)
            {
                switch (batchState)
                {
                    case BATCH_STATE.None:
                        batchState = statusNone(batchTransition);
                        break;
                    case BATCH_STATE.ALG_DOSEER_TA02:
                        batchState = statusALG_DOSEER_TA02(batchTransition);
                        break;
                    case BATCH_STATE.ALG_DOSEER_TA03:
                        batchState = statusALG_DOSEER_TA03(batchTransition);
                        break;
                    case BATCH_STATE.ALG_DOSEER_TA04:
                        batchState = statusALG_DOSEER_TA04(batchTransition);
                        break;
                    case BATCH_STATE.ALG_FILL_KE01:
                        batchState = statusALG_FILL_KE01(batchTransition);
                        break;
                    case BATCH_STATE.ALG_MIX_KE01:
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
        }
    }
}
