using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduLab_Process_Simulator
{
    class SimulationRecorder
    {
        private readonly soapProcess soapProcess;
        private DataTable dataTable;

        public SimulationRecorder(soapProcess IsoapProcess)
        {
            
            this.soapProcess = IsoapProcess;

            dataTable = new DataTable();

            dataTable.Columns.Add(soapProcess.TA01.strTankName, typeof(System.String));
            dataTable.Columns.Add(soapProcess.TA02.strTankName, typeof(System.String));
            dataTable.Columns.Add(soapProcess.TA03.strTankName, typeof(System.String));
            dataTable.Columns.Add(soapProcess.TA04.strTankName, typeof(System.String));
            dataTable.Columns.Add(soapProcess.KE01.strTankName, typeof(System.String));

        }

        public void RecordData()
        {
            int intRowCount = dataTable.Rows.Count;
            DataRow dataRow = dataTable.NewRow();

            dataRow[0] = soapProcess.TA01.GetVolume().ToString();
            dataRow[1] = soapProcess.TA02.GetVolume().ToString();
            dataRow[2] = soapProcess.TA03.GetVolume().ToString();
            dataRow[3] = soapProcess.TA04.GetVolume().ToString();
            dataRow[4] = soapProcess.KE01.GetVolume().ToString();

            dataTable.Rows.InsertAt(dataRow, intRowCount + 1);
            dataTable.AcceptChanges();
        }

        public void DebugData()
        {
            int intColumnCount = dataTable.Columns.Count;
            int intRowCount = dataTable.Rows.Count;

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
