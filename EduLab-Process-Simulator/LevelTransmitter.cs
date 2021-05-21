using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduLab_Process_Simulator
{
    public class Leveltransmitter
    {
        public string strLevelTransmitterName { get; set; }        
        private Tank tank;

        /// <summary>
        /// Simulated level transmitter object.
        /// </summary>
        /// <param name="strObjectName">Name of this level transmitter</param>
        /// <param name="Itank">Tank that this level transmitter is attached to</param>
        public Leveltransmitter(string strObjectName, Tank Itank)
        {
            strLevelTransmitterName = strObjectName;
            tank = Itank;
        }

        /// <summary>
        /// Retrieves the measurement of the object that this sensor is attached to.
        /// </summary>
        /// <returns>Float containing the measurement value</returns>
        public float GetLevel()
        {
            return tank.GetVolume();
        }
    }
}
