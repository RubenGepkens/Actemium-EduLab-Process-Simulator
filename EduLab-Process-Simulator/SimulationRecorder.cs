/* EduLab-Proces-Sumulator - SimulationRecorder.cs
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
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduLab_Process_Simulator
{
    /// <summary>
    /// Class that contains a method to record the simulation and stores the data.
    /// </summary>
    class SimulationRecorder
    {
        private readonly SoapProcess soapProcess;
        public DataTable dataTable { get; private set; }

        private int intCycleCounter;

        /// <summary>
        /// Create SimulationRecorder.
        /// </summary>
        /// <param name="IsoapProcess"></param>
        public SimulationRecorder(SoapProcess IsoapProcess)
        {
            
            this.soapProcess = IsoapProcess;

            dataTable = new DataTable();
            
            intCycleCounter = 0;

            dataTable.Columns.Add("Cycle", typeof(System.UInt32));
            dataTable.Columns.Add("Timestamp", typeof(System.DateTime));

            dataTable.Columns.Add("BATCH_STATE", typeof(System.String));
            dataTable.Columns.Add("BATCH_TRANSITION", typeof(System.String));

            dataTable.Columns.Add(soapProcess.TA01.strTankName, typeof(System.String));
            dataTable.Columns.Add(soapProcess.TA02.strTankName, typeof(System.String));
            dataTable.Columns.Add(soapProcess.TA03.strTankName, typeof(System.String));
            dataTable.Columns.Add(soapProcess.TA04.strTankName, typeof(System.String));
            dataTable.Columns.Add(soapProcess.KE01.strTankName, typeof(System.String));
            
            dataTable.Columns.Add(soapProcess.CV02.strValveName, typeof(System.String));
            dataTable.Columns.Add(soapProcess.CV03.strValveName, typeof(System.String));
            dataTable.Columns.Add(soapProcess.CV04.strValveName, typeof(System.String));

            dataTable.Columns.Add(soapProcess.SV01.strValveName, typeof(System.String));
            dataTable.Columns.Add(soapProcess.SV05A.strValveName, typeof(System.String));
            dataTable.Columns.Add(soapProcess.SV05B.strValveName, typeof(System.String));
            dataTable.Columns.Add(soapProcess.SV10.strValveName, typeof(System.String));
            dataTable.Columns.Add(soapProcess.SV12.strValveName, typeof(System.String));
            dataTable.Columns.Add(soapProcess.SV21.strValveName, typeof(System.String));
            dataTable.Columns.Add(soapProcess.SV22.strValveName, typeof(System.String));
            dataTable.Columns.Add(soapProcess.SV31.strValveName, typeof(System.String));
            dataTable.Columns.Add(soapProcess.SV40.strValveName, typeof(System.String));
            dataTable.Columns.Add(soapProcess.SV41.strValveName, typeof(System.String));
            dataTable.Columns.Add(soapProcess.SV50.strValveName, typeof(System.String));
            dataTable.Columns.Add(soapProcess.SV51.strValveName, typeof(System.String));

            dataTable.Columns.Add(soapProcess.LT02.strLevelTransmitterName, typeof(System.String));
            dataTable.Columns.Add(soapProcess.LT03.strLevelTransmitterName, typeof(System.String));
            dataTable.Columns.Add(soapProcess.LT04.strLevelTransmitterName, typeof(System.String));

            dataTable.Columns.Add(soapProcess.PT02.strPressureTransmitterName, typeof(System.String));

            dataTable.Columns.Add(soapProcess.PO01.strPumpName, typeof(System.String));
            dataTable.Columns.Add(soapProcess.PO02.strPumpName, typeof(System.String));
            dataTable.Columns.Add(soapProcess.PO03.strPumpName, typeof(System.String));
            dataTable.Columns.Add(soapProcess.PO04.strPumpName, typeof(System.String));
            dataTable.Columns.Add(soapProcess.PO05.strPumpName, typeof(System.String));            
        }

        /// <summary>
        /// Recorde one simulation cycle.
        /// </summary>
        public void RecordData()
        {
            int intRowCount = dataTable.Rows.Count;
            DataRow dataRow = dataTable.NewRow();
            
            // To be used as a managed pointer for the column counter in AddDataRow.
            int intIndex = 0;

            AddDataRow(ref dataRow, ref intIndex, intCycleCounter);
            AddDataRow(ref dataRow, ref intIndex, DateTime.Now);
            
            AddDataRow(ref dataRow, ref intIndex, soapProcess.batchState);
            AddDataRow(ref dataRow, ref intIndex, soapProcess.batchTransition);

            AddDataRow(ref dataRow, ref intIndex, soapProcess.TA01.GetVolume());
            AddDataRow(ref dataRow, ref intIndex, soapProcess.TA02.GetVolume());
            AddDataRow(ref dataRow, ref intIndex, soapProcess.TA03.GetVolume());
            AddDataRow(ref dataRow, ref intIndex, soapProcess.TA04.GetVolume());
            AddDataRow(ref dataRow, ref intIndex, soapProcess.KE01.GetVolume());

            AddDataRow(ref dataRow, ref intIndex, soapProcess.CV02.GetStatus());
            AddDataRow(ref dataRow, ref intIndex, soapProcess.CV03.GetStatus());
            AddDataRow(ref dataRow, ref intIndex, soapProcess.CV04.GetStatus());

            AddDataRow(ref dataRow, ref intIndex, soapProcess.SV01.IsOpen().ToString());
            AddDataRow(ref dataRow, ref intIndex, soapProcess.SV05A.IsOpen().ToString());
            AddDataRow(ref dataRow, ref intIndex, soapProcess.SV05B.IsOpen().ToString());
            AddDataRow(ref dataRow, ref intIndex, soapProcess.SV10.IsOpen().ToString());
            AddDataRow(ref dataRow, ref intIndex, soapProcess.SV12.IsOpen().ToString());
            AddDataRow(ref dataRow, ref intIndex, soapProcess.SV21.IsOpen().ToString());
            AddDataRow(ref dataRow, ref intIndex, soapProcess.SV22.IsOpen().ToString());
            AddDataRow(ref dataRow, ref intIndex, soapProcess.SV31.IsOpen().ToString());
            AddDataRow(ref dataRow, ref intIndex, soapProcess.SV40.IsOpen().ToString());
            AddDataRow(ref dataRow, ref intIndex, soapProcess.SV41.IsOpen().ToString());
            AddDataRow(ref dataRow, ref intIndex, soapProcess.SV50.IsOpen().ToString());
            AddDataRow(ref dataRow, ref intIndex, soapProcess.SV51.IsOpen().ToString());

            AddDataRow(ref dataRow, ref intIndex, soapProcess.LT02.GetLevel().ToString());
            AddDataRow(ref dataRow, ref intIndex, soapProcess.LT03.GetLevel().ToString());
            AddDataRow(ref dataRow, ref intIndex, soapProcess.LT04.GetLevel().ToString());

            AddDataRow(ref dataRow, ref intIndex, soapProcess.PT02.GetPressure().ToString());

            AddDataRow(ref dataRow, ref intIndex, soapProcess.PO01.GetStatus().ToString());
            AddDataRow(ref dataRow, ref intIndex, soapProcess.PO02.GetStatus().ToString());
            AddDataRow(ref dataRow, ref intIndex, soapProcess.PO03.GetStatus().ToString());
            AddDataRow(ref dataRow, ref intIndex, soapProcess.PO04.GetStatus().ToString());
            AddDataRow(ref dataRow, ref intIndex, soapProcess.PO05.GetStatus().ToString());

            /*
            dataRow[0] = soapProcess.TA01.GetVolume().ToString();
            dataRow[1] = soapProcess.TA02.GetVolume().ToString();
            dataRow[2] = soapProcess.TA03.GetVolume().ToString();
            dataRow[3] = soapProcess.TA04.GetVolume().ToString();
            dataRow[4] = soapProcess.KE01.GetVolume().ToString();

            dataRow[5] = soapProcess.CV02.GetStatus().ToString();
            dataRow[6] = soapProcess.CV03.GetStatus().ToString();
            dataRow[7] = soapProcess.CV04.GetStatus().ToString();

            dataRow[8] = soapProcess.SV01.IsOpen().ToString();
            dataRow[9] = soapProcess.SV05A.IsOpen().ToString();
            dataRow[10] = soapProcess.SV05B.IsOpen().ToString();
            dataRow[11] = soapProcess.SV10.IsOpen().ToString();
            dataRow[12] = soapProcess.SV12.IsOpen().ToString();
            dataRow[13] = soapProcess.SV21.IsOpen().ToString();
            dataRow[14] = soapProcess.SV22.IsOpen().ToString();
            dataRow[15] = soapProcess.SV31.IsOpen().ToString();
            dataRow[16] = soapProcess.SV40.IsOpen().ToString();
            dataRow[17] = soapProcess.SV41.IsOpen().ToString();
            dataRow[18] = soapProcess.SV50.IsOpen().ToString();
            dataRow[19] = soapProcess.SV51.IsOpen().ToString();

            dataRow[20] = soapProcess.LT02.GetLevel().ToString();
            dataRow[21] = soapProcess.LT03.GetLevel().ToString();
            dataRow[22] = soapProcess.LT04.GetLevel().ToString();

            dataRow[23] = soapProcess.PT02.GetPressure().ToString();

            dataRow[24] = soapProcess.PO01.GetStatus().ToString();
            dataRow[25] = soapProcess.PO02.GetStatus().ToString();
            dataRow[26] = soapProcess.PO03.GetStatus().ToString();
            dataRow[27] = soapProcess.PO04.GetStatus().ToString();
            dataRow[28] = soapProcess.PO05.GetStatus().ToString();
            */

            dataTable.Rows.InsertAt(dataRow, intRowCount + 1);
            dataTable.AcceptChanges();

            intCycleCounter++;
        }

        /// <summary>
        /// Helper method that inserts a new row to the dataRow.
        /// </summary>
        /// <param name="dataRow">DataRow object passed by reference.</param>
        /// <param name="index">Index counter passed by reference.</param>
        /// <param name="dataItem">Data item to insert.</param>
        private void AddDataRow(ref DataRow dataRow, ref int index, object dataItem)
        {
            //int intRowCounter = dataRow.Table.Rows.Count;           
            dataRow[index] = dataItem.ToString();
            index++;
        }

        /// <summary>
        /// Print debugdata in the console.
        /// </summary>
        public void DebugData()
        {            
            int intColumnCount = dataTable.Columns.Count;
            int intRowCount = dataTable.Rows.Count;

            Console.WriteLine("DebugData\tColumns: {0}\tRows: {1}", intColumnCount, intRowCount);

            Console.Write("Data:\t");
            for (int x = 0; x < intColumnCount; x++)
            {
                Console.Write("{0}\t", dataTable.Columns[x].ColumnName);
            }
            Console.Write("\n");


            for ( int y = 0; y < intRowCount; y++)
            {
                Console.Write("{0}:\t", y);
                for ( int x = 0; x < intColumnCount; x++)
                {
                    Console.Write("{0}\t", dataTable.Rows[y][x].ToString());
                }
                Console.Write("\n");
            }           
        }
    }
}
