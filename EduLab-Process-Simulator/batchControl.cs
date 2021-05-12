using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduLab_Process_Simulator
{
    public class batchControl
    {
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

        public enum BATCH_TRANSITION
        {
            BUSY,
            COMPLETE
        };

        /// <summary>
        /// None -> ALG_DOSEER_TA02
        /// </summary>
        /// <param name="batchTransition"></param>
        /// <returns></returns>
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
        /// <returns></returns>
        public BATCH_STATE statusALG_DOSEER_TA02(BATCH_TRANSITION batchTransition)
        {
            switch (batchTransition)
            {
                case BATCH_TRANSITION.BUSY:
                    return BATCH_STATE.ALG_DOSEER_TA02;
                case BATCH_TRANSITION.COMPLETE:
                    return BATCH_STATE.ALG_DOSEER_TA02;
                default:
                    return BATCH_STATE.ALG_DOSEER_TA02;
            }
        }

        /// <summary>
        /// ALG_DOSEER_TA03 -> ALG_DOSEER_TA04
        /// </summary>
        /// <param name="batchTransition"></param>
        /// <returns></returns>
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
        /// <returns></returns>
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
        /// <returns></returns>
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
        /// <returns></returns>
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
        /// <returns></returns>
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
        /// <returns></returns>
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
        /// <returns></returns>
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