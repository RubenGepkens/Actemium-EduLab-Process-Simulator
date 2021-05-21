using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduLab_Process_Simulator
{
    class PressureTransmitter
    {
        public string strPressureTransmitterName { get; set; }
        private Tank tank;

        /// <summary>
        /// Simulated pressure transmitter object.
        /// </summary>
        /// <param name="strObjectName">Name of this pressure transmitter</param>
        /// <param name="Itank">Tank that this pressure transmitter is attached to</param>
        public PressureTransmitter(string strObjectName, Tank Itank){
            strPressureTransmitterName = strObjectName;
            tank = Itank;            
        }

        /// <summary>
        /// Retrieves the measurement of the object that this sensor is attached to.
        /// </summary>
        /// <returns>Float containing the measurement value</returns>
        public float GetPressure()
        {
            return tank.GetPressure();
        }
    }
}
