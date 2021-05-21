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
        public int intValvePosition { get; set; }

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
            // At this moment the opening and closing of the valve is not simulated.
            // Therefore the valve will take the requested position immediately. 
            intValvePosition = 100;
        }

        /// <summary>
        /// Closes the valve.
        /// </summary>
        public void closeValve()
        {
            // At this moment the opening and closing of the valve is not simulated.
            // Therefore the valve will take the requested position immediately. 
            intValvePosition = 0;
        }

        /// <summary>
        /// Returns wheter the valve is opened or not.
        /// </summary>
        /// <returns>True if the valve is open or False if it is closed.</returns>
        public bool isOpen()
        {
            if ( intValvePosition >= 95 )
            {
                return true;
            } else
            {
                return false;
            }
        }

        /// <summary>
        /// Returns wheter the valve is closed or not.
        /// </summary>
        /// <returns>True if the valve is closed or False if it is opened.</returns>
        public bool isClosed()
        {
            if ( intValvePosition <= 5)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
