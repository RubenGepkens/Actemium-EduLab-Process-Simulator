/* EduLab-Proces-Sumulator - batchControl
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
    /// Class replicating the FactoryTalk Batch programme for the EduLab soap process.
    /// The batch sequence is replicated using a finite state machine.
    /// </summary>
    public class batchControl
    {
        /// <summary>
        /// Enumerator for the different operations in the batch.
        /// </summary>
        public enum BATCH_STATE
        {
            None,
            ALG_DOSEER_TA02,
            ALG_DOSEER_TA03,
            ALG_DOSEER_TA04,
            ALG_FILL_KE01,
            ALG_ACCEPT_LIQUID_KE01,
            ALG_MIX_KE01,
            ALG_EMPTY_KE01,
            Done
        };

        /// <summary>
        /// Eneumerator for the transitions in BATCH_STATE.
        /// </summary>
        public enum BATCH_TRANSITION
        {
            BUSY,
            COMPLETE
        };

        /// <summary>
        /// None -> ALG_DOSEER_TA02
        /// </summary>
        /// <param name="batchTransition"></param>
        /// <returns>BATCH_STATE</returns>
        public BATCH_STATE statusNone(BATCH_TRANSITION batchTransition)
        {
            switch (batchTransition)
            {
                case BATCH_TRANSITION.BUSY:
                    return BATCH_STATE.None;
                case BATCH_TRANSITION.COMPLETE:
                    return BATCH_STATE.ALG_DOSEER_TA02;
                default:
                    return BATCH_STATE.None;
            }
        }

        /// <summary>
        /// ALG_DOSEER_TA02 -> ALG_DOSEER_TA03
        /// </summary>
        /// <param name="batchTransition"></param>
        /// <returns>BATCH_STATE</returns>
        public BATCH_STATE statusALG_DOSEER_TA02(BATCH_TRANSITION batchTransition)
        {
            switch (batchTransition)
            {
                case BATCH_TRANSITION.BUSY:
                    return BATCH_STATE.ALG_DOSEER_TA02;
                case BATCH_TRANSITION.COMPLETE:
                    return BATCH_STATE.ALG_DOSEER_TA03;
                default:
                    return BATCH_STATE.ALG_DOSEER_TA02;
            }
        }

        /// <summary>
        /// ALG_DOSEER_TA03 -> ALG_DOSEER_TA04
        /// </summary>
        /// <param name="batchTransition"></param>
        /// <returns>BATCH_STATE</returns>
        public BATCH_STATE statusALG_DOSEER_TA03(BATCH_TRANSITION batchTransition)
        {
            switch (batchTransition)
            {
                case BATCH_TRANSITION.BUSY:
                    return BATCH_STATE.ALG_DOSEER_TA03;
                case BATCH_TRANSITION.COMPLETE:
                    return BATCH_STATE.ALG_DOSEER_TA04;
                default:
                    return BATCH_STATE.ALG_DOSEER_TA03;
            }
        }

        /// <summary>
        /// ALG_DOSEER_TA04 -> ALG_FILL_KE01
        /// </summary>
        /// <param name="batchTransition"></param>
        /// <returns>BATCH_STATE</returns>
        public BATCH_STATE statusALG_DOSEER_TA04(BATCH_TRANSITION batchTransition)
        {
            switch (batchTransition)
            {
                case BATCH_TRANSITION.BUSY:
                    return BATCH_STATE.ALG_DOSEER_TA04;
                case BATCH_TRANSITION.COMPLETE:
                    return BATCH_STATE.ALG_FILL_KE01;
                default:
                    return BATCH_STATE.ALG_DOSEER_TA04;
            }
        }

        /// <summary>
        /// ALG_FILL_KE01 -> ALG_ACCEPT_LIQUID_KE01
        /// </summary>
        /// <param name="batchTransition"></param>
        /// <returns>BATCH_STATE</returns>
        public BATCH_STATE statusALG_FILL_KE01(BATCH_TRANSITION batchTransition)
        {
            switch (batchTransition)
            {
                case BATCH_TRANSITION.BUSY:
                    return BATCH_STATE.ALG_FILL_KE01;
                case BATCH_TRANSITION.COMPLETE:
                    return BATCH_STATE.ALG_ACCEPT_LIQUID_KE01;
                default:
                    return BATCH_STATE.ALG_FILL_KE01;
            }
        }

        /// <summary>
        /// ALG_ACCEPT_LIQUID_KE01 -> ALG_MIX_KE01
        /// </summary>
        /// <param name="batchTransition"></param>
        /// <returns>BATCH_STATE</returns>
        public BATCH_STATE statusALG_ACCEPT_LIQUID_KE01(BATCH_TRANSITION batchTransition)
        {
            switch (batchTransition)
            {
                case BATCH_TRANSITION.BUSY:
                    return BATCH_STATE.ALG_ACCEPT_LIQUID_KE01;
                case BATCH_TRANSITION.COMPLETE:
                    return BATCH_STATE.ALG_MIX_KE01;
                default:
                    return BATCH_STATE.ALG_ACCEPT_LIQUID_KE01;
            }
        }

        /// <summary>
        /// ALG_MIX_KE01 -> ALG_MIX_KE01
        /// </summary>
        /// <param name="batchTransition"></param>
        /// <returns>BATCH_STATE</returns>
        public BATCH_STATE statusALG_MIX_KE01(BATCH_TRANSITION batchTransition)
        {
            switch (batchTransition)
            {
                case BATCH_TRANSITION.BUSY:
                    return BATCH_STATE.ALG_MIX_KE01;
                case BATCH_TRANSITION.COMPLETE:
                    return BATCH_STATE.ALG_EMPTY_KE01;
                default:
                    return BATCH_STATE.ALG_MIX_KE01;
            }
        }

        /// <summary>
        /// ALG_EMPTY_KE01 -> Done
        /// </summary>
        /// <param name="batchTransition"></param>
        /// <returns>BATCH_STATE</returns>
        public BATCH_STATE statusALG_EMPTY_KE01(BATCH_TRANSITION batchTransition)
        {
            switch (batchTransition)
            {
                case BATCH_TRANSITION.BUSY:
                    return BATCH_STATE.ALG_EMPTY_KE01;
                case BATCH_TRANSITION.COMPLETE:
                    return BATCH_STATE.Done;
                default:
                    return BATCH_STATE.ALG_EMPTY_KE01;
            }
        }

        /// <summary>
        /// Done -> None
        /// </summary>
        /// <param name="batchTransition"></param>
        /// <returns>BATCH_STATE</returns>
        public BATCH_STATE statusDone(BATCH_TRANSITION batchTransition)
        {
            switch (batchTransition)
            {
                case BATCH_TRANSITION.BUSY:
                    return BATCH_STATE.Done;
                case BATCH_TRANSITION.COMPLETE:
                    return BATCH_STATE.None;
                default:
                    return BATCH_STATE.Done;
            }
        }
    }
}