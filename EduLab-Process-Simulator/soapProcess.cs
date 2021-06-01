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
        public BATCH_STATE batchState = BATCH_STATE.None;
        public BATCH_TRANSITION batchTransition = BATCH_TRANSITION.BUSY;

        // frmMain object, used for the invoke delegate to update the UI elements.
        public frmMain frmMain;

        // Simulation speed related variables.
        public int intThreadTime = 1000;
        public readonly int intDefaultThreadTime = 1000;
        public int intSimulationCycle = 0;

        // Simulation properties
        private bool blnRecordSimulation = false;
        
        // Used for time based functions.
        public int intSimulationCounter = 0;

        #region Simulation objects
        // Simulation objects
        public Tank TA01;
        public Tank TA02;
        public Tank TA03;
        public Tank TA04;
        public Tank KE01;

        public ControlValve CV02;
        public ControlValve CV03;
        public ControlValve CV04;

        public SolenoidValve SV01;
        public SolenoidValve SV05A;
        public SolenoidValve SV05B;
        public SolenoidValve SV10;
        public SolenoidValve SV12;
        public SolenoidValve SV21;
        public SolenoidValve SV22;
        public SolenoidValve SV31;
        public SolenoidValve SV40;
        public SolenoidValve SV41;
        public SolenoidValve SV50;
        public SolenoidValve SV51;


        public Leveltransmitter LT02;
        public Leveltransmitter LT03;
        public Leveltransmitter LT04;

        public PressureTransmitter PT02;

        public Pump PO01;
        public Pump PO02;
        public Pump PO03;
        public Pump PO04;
        public Pump PO05;
        #endregion

        #region Constructors and initializer.

        /// <summary>
        /// Create a simulation object using default parameters.
        /// </summary>
        public soapProcess()
        {
            Console.WriteLine("soapProcess()");

            // Since a default constructor was used to create a simulation object, use default parameters.
            intThreadTime = intDefaultThreadTime;
            blnRecordSimulation = false;
            initialize();
        }

        /// <summary>
        /// Allow the simulation acceleration to be set using this constructor.
        /// </summary>
        /// <param name="simulationAcceleration"></param>
        public soapProcess(int SimulationAcceleration, bool RecordSimulation)
        {
            if (SimulationAcceleration <= -1 || SimulationAcceleration >= 128)
            {
                intThreadTime = 0;
            } else
            {
                // Calculate the threadtime for the requested acceleration speed.
                float fltTemp = 1000 / SimulationAcceleration;
                intThreadTime = (int)Math.Round(fltTemp, 0);
            }

            blnRecordSimulation = RecordSimulation;

            Console.WriteLine("Simulation acceleration {0}x with cycle time {1} ms", SimulationAcceleration, intThreadTime);

            initialize();
        }

        /// <summary>
        /// Sets up this class for simulation.
        /// Defines the simulation objects.
        /// </summary>
        void initialize()
        {
            /*
            TA01 = new Tank("TA01", 1250, 1250, 10, 10);
            TA02 = new Tank("TA02", 50, 0, 10.23F, 3.34F);
            TA03 = new Tank("TA03", 125, 0, 6.23F, 3.34F);
            TA04 = new Tank("TA04", 50, 0, 2.23F, 3.34F);
            KE01 = new Tank("KE01", 225, 0, 5F, 5F);
            */
            TA01 = new Tank("TA01", 1250, 1250, 10, 10);
            TA02 = new Tank("TA02", 50, 0, 10, 10);
            TA03 = new Tank("TA03", 125, 0, 10, 10);
            TA04 = new Tank("TA04", 50, 0, 10, 10);
            KE01 = new Tank("KE01", 225, 0, 10, 10);

            CV02 = new ControlValve("CV02");
            CV03 = new ControlValve("CV03");
            CV04 = new ControlValve("CV04");

            SV01 = new SolenoidValve("SV01");
            SV05A = new SolenoidValve("SV05A");
            SV05B = new SolenoidValve("SV05B");
            SV10 = new SolenoidValve("SV10");
            SV12 = new SolenoidValve("SV12");
            SV21 = new SolenoidValve("SV21");
            SV22 = new SolenoidValve("SV22");
            SV31 = new SolenoidValve("SV31");
            SV40 = new SolenoidValve("SV40");
            SV41 = new SolenoidValve("SV41");
            SV50 = new SolenoidValve("SB50");
            SV51 = new SolenoidValve("SV51");

            LT02 = new Leveltransmitter("LT02", TA02);
            LT03 = new Leveltransmitter("LT03", TA03);
            LT04 = new Leveltransmitter("LT04", TA04);

            PO01 = new Pump("PO01");
            PO02 = new Pump("PO02");
            PO03 = new Pump("PO03");
            PO04 = new Pump("PO04");
            PO05 = new Pump("PO05");
        }

        #endregion

        #region General simulation functions

        /// <summary>
        /// Starts the sequence of producing a batch of soap.
        /// </summary>
        public void startBatch(frmMain IfrmMain)
        {
            frmMain = IfrmMain;

            while (batchState != BATCH_STATE.Done)
            {
                intSimulationCycle++;
                updateBatchStatus();
                updateUI();
                                
                if (blnRecordSimulation)
                {
                    RecordData();
                }                
                
                Console.WriteLine("Cycle: {0}\tState: {1}",intSimulationCycle, batchState);

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
                    batchTransition = ALG_EMPTY_KE01();
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
            frmMain.UpdateUI( batchState.ToString(),
                                   TA01,
                                   LT02,
                                   LT03,
                                   LT04,
                                   KE01,

                                   CV02,
                                   CV03,
                                   CV04,

                                   SV01,
                                   SV05A,
                                   SV05B,
                                   SV10,
                                   SV12,
                                   SV21,
                                   SV22,
                                   SV31,
                                   SV40,
                                   SV41,
                                   SV50,
                                   SV51,

                                   PO01,
                                   PO02,
                                   PO03,
                                   PO04,
                                   PO05
            );
        }

        public void RecordData()
        {
            frmMain.RecordData();
        }

        #endregion

        #region Soap Process (BATCH_TRANSITIONs)

        /* This region contains the actual soap proces batch definition.
         * The proces programmed below is the FactoryTalk Batch programme translated to C# code.
         * The simulated proces below may not represent the actual batch process and it may require some polishing.
         */
        public BATCH_TRANSITION ALG_DOSEER_TA02()
        {
            // LT02 >= 50 L

            // If SV is closed, open it.
            if (SV12.IsClosed())
            {
                SV12.OpenValve();
            }

            // Start pump if not already started.
            if (PO01.IsStopped())
            {
                PO01.Start();
            }

            // If CV is closed, open it.
            if (CV02.IsClosed())
            {
                CV02.OpenValve();
            }

            // If CV is opened and pump is started, simulate inflow of fluid.
            if (SV12.IsOpen() && PO01.IsRunning() && CV02.IsOpen())
            {
                TA01.fltEmptyRate = TA02.fltFillRate;

                TA01.EmptyTank();
                TA02.FillTank();
            }

            // Operation is complete when tank is filled.
            if (TA02.IsFull())
            {
                CV02.CloseValve();
                return BATCH_TRANSITION.COMPLETE;
            }
            else
            {
                return BATCH_TRANSITION.BUSY;
            }
        }

        public BATCH_TRANSITION ALG_DOSEER_TA03()
        {
            // LT03 >= 125 L

            // If SV is closed, open it.
            if (SV12.IsClosed())
            {
                SV12.OpenValve();
            }

            // Start pump if not already started.
            if (PO01.IsStopped())
            {
                PO01.Start();
            }

            // To allow filling of TA03, open CV04 if it is closed.
            if (CV04.IsClosed())
            {
                CV04.OpenValve();
            }

            // If CV is opened, simulate inflow of fluid.
            if (SV12.IsOpen() && PO01.IsRunning() && CV04.IsOpen())
            {
                TA01.fltEmptyRate = TA03.fltFillRate;

                TA01.EmptyTank();
                TA03.FillTank();
            }

            // Operation is completed when tank is filled.
            if (TA03.IsFull())
            {
                CV04.CloseValve();
                return BATCH_TRANSITION.COMPLETE;
            }
            else
            {
                return BATCH_TRANSITION.BUSY;
            }
        }

        public BATCH_TRANSITION ALG_DOSEER_TA04()
        {
            // LT04 >= 50 L

            // If SV is closed, open it.
            if (SV12.IsClosed())
            {
                SV12.OpenValve();
            }

            // Start pump if not already started.
            if (PO01.IsStopped())
            {
                PO01.Start();
            }

            // If SV is closed, open it.
            if (SV40.IsClosed())
            {
                SV40.OpenValve();
            }

            // Fill tank if above conditions are met.
            if (SV12.IsOpen() && PO01.IsRunning() && SV40.IsOpen())
            {
                TA01.fltEmptyRate = TA04.fltFillRate;

                TA01.EmptyTank();
                TA04.FillTank();
            }

            // Operation is completed when tank is filled.
            if (TA04.IsFull())
            {
                SV12.CloseValve();
                PO01.Stop();
                SV40.CloseValve();
                return BATCH_TRANSITION.COMPLETE;
            }
            else
            {
                return BATCH_TRANSITION.BUSY;
            }
        }

        public BATCH_TRANSITION ALG_FILL_KE01()
        {
            // Empty TA02
            if (TA02.IsEmpty() == false) // *not empty* means tanks still contains liquid!
            {
                if (SV21.IsClosed())
                {
                    SV21.OpenValve();
                }

                if (SV22.IsClosed())
                {
                    SV22.OpenValve();
                }

                if (PO02.IsStopped())
                {
                    PO02.Start();
                }

                if (SV21.IsOpen() && SV22.IsOpen() && PO02.IsRunning())
                {
                    KE01.fltFillRate = TA02.fltEmptyRate;

                    TA02.EmptyTank();
                    KE01.FillTank();
                }
            }

            // Emptying of TA02 finished, close the valves.
            if (TA02.IsEmpty())
            {
                if (SV21.IsOpen())
                {
                    SV21.CloseValve();
                }

                if (SV22.IsOpen())
                {
                    SV22.CloseValve();
                }

                if (PO02.IsRunning())
                {
                    PO02.Stop();
                }
            }

            // Empty TA03
            if (TA02.IsEmpty() && TA03.IsEmpty() == false) // *not empty* means tanks still contains liquid!
            {
                if (CV03.IsClosed())
                {
                    CV03.CommandValve(100);
                }

                if (SV31.IsClosed())
                {
                    SV31.OpenValve();
                }

                if (PO03.IsStopped())
                {
                    PO03.Start();
                }

                if (CV03.IsOpen() && SV31.IsOpen() && PO03.IsRunning())
                {
                    KE01.fltFillRate = TA03.fltEmptyRate;

                    TA03.EmptyTank();
                    KE01.FillTank();
                }
            }

            // Emptying of TA03 finished, close the valves.
            if (TA03.IsEmpty())
            {
                if (CV03.IsOpen())
                {
                    CV03.CloseValve();
                }

                if (SV31.IsOpen())
                {
                    SV31.CloseValve();
                }

                if (PO03.IsRunning())
                {
                    PO03.Stop();
                }
            }

            // Empty TA04
            if (TA02.IsEmpty() && TA03.IsEmpty() && TA04.IsEmpty() == false) // *not empty* means tanks still contains liquid!
            {
                if (SV41.IsClosed())
                {
                    SV41.OpenValve();
                }

                if (SV41.IsOpen())
                {
                    KE01.fltFillRate = TA04.fltEmptyRate;

                    TA04.EmptyTank();
                    KE01.FillTank();
                }
            }

            // Emptying of TA04 finished, close the valves.
            if (TA04.IsEmpty())
            {
                if (SV41.IsOpen())
                {
                    SV41.CloseValve();
                }
            }

            // Check if the ALG_FILL_KE01() operation is complete.
            if (TA04.IsEmpty() && TA03.IsEmpty() && TA04.IsEmpty())
            {
                return BATCH_TRANSITION.COMPLETE;
            }
            else
            {
                return BATCH_TRANSITION.BUSY;
            }
        }

        public BATCH_TRANSITION ALG_ACCEPT_LIQUID_KE01()
        {
            return BATCH_TRANSITION.COMPLETE;
        }

        public BATCH_TRANSITION ALG_MIX_KE01()
        {
            // Mix for 30 seconds.

            if (intSimulationCounter <= 30)
            {
                intSimulationCounter++;
                return BATCH_TRANSITION.BUSY;
            } else
            {
                intSimulationCounter = 0;
                return BATCH_TRANSITION.COMPLETE;
            }           
        }

        public BATCH_TRANSITION ALG_EMPTY_KE01()
        {
            if (KE01.IsEmpty() == false)
            {
                if (SV51.IsClosed())
                {
                    SV51.OpenValve();
                }

                if (SV10.IsClosed())
                {
                    SV10.OpenValve();
                }

                if (PO04.IsStopped())
                {
                    PO04.Start();
                }

                if (SV51.IsOpen() && SV10.IsOpen() && PO04.IsRunning())
                {
                    TA01.fltFillRate = KE01.fltEmptyRate;

                    KE01.EmptyTank();
                    TA01.FillTank();
                }
            }

            if (KE01.IsEmpty())
            {
                if (SV51.IsOpen())
                {
                    SV51.CloseValve();
                }

                if (SV10.IsOpen())
                {
                    SV10.CloseValve();
                }

                if (PO04.IsRunning())
                {
                    PO04.Stop();
                }

                return BATCH_TRANSITION.COMPLETE;
            } else
            {
                return BATCH_TRANSITION.BUSY;
            }
        }

        #endregion
    }
}