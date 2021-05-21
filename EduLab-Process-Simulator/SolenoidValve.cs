using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduLab_Process_Simulator
{
    public class SolenoidValve
    {
        public string strValveName { get; set; }
        public bool blnValvePosition { get; set; }

        /// <summary>
        /// Simulated solenoid valve.
        /// </summary>
        public SolenoidValve()
        {

        }

        /// <summary>
        /// Simulated solenoid valve.
        /// </summary>
        /// <param name="strObjectName"></param>
        public SolenoidValve(string strObjectName)
        {
            strValveName = strObjectName;
        }

        /// <summary>
        /// Opens the valve.
        /// </summary>
        public void openValve()
        {
            blnValvePosition = true;
        }

        /// <summary>
        /// Closes the valve.
        /// </summary>
        public void closeValve()
        {
            blnValvePosition = false;
        }

        /// <summary>
        /// Returns the status of the valve.
        /// </summary>
        /// <returns>True for an open valve and False for a closed valve.</returns>
        public bool getStatus()
        {
            //Console.WriteLine("{0}: is {1}", strValveName, blnValveStatus);
            return blnValvePosition;
        }
    }
}
