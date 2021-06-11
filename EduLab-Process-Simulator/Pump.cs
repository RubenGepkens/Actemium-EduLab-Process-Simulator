/* EduLab-Proces-Sumulator - Pump.cs
 * 
 * Simulator for the process installation of the EduLab. Made for Actemium in Veghel, The Netherlands.
 * 
 * Copyright (c) 2021 Ruben Gepkens & Maurits Duel
 * 
 * This software is distributed using the MIT License.
 * For terms of use read the LICENSE.md document included in this repository or visit: www.mit-license.org.
 * 
 * Icons used in this project are taken from the GNOME desktop project ('gnome-icon-theme 2.20.0') released under the GNU GPLv2 license. 
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduLab_Process_Simulator
{
    public class Pump
    {
        public string strPumpName { get; set; }
        public bool blnPumpRunning { get; set; }

        /// <summary>
        /// Simulated pump.
        /// </summary>
        public Pump()
        {
            blnPumpRunning = false;
        }

        /// <summary>
        /// Simulated pump.
        /// </summary>
        /// <param name="strObjectname"></param>
        public Pump(string strObjectname)
        {
            strPumpName = strObjectname;
            blnPumpRunning = false;
        }

        /// <summary>
        /// Starts the pump.
        /// </summary>
        public void Start()
        {
            blnPumpRunning = true;
        }

        /// <summary>
        /// Stops the pump
        /// </summary>
        public void Stop()
        {
            blnPumpRunning = false;
        }

        /// <summary>
        /// Retrieves the pump status.
        /// </summary>
        /// <returns>true if the pump is running and false if it is stopped</returns>
        public bool GetStatus()
        {
            return blnPumpRunning;
        }

        /// <summary>
        /// Retrevies the pump status
        /// </summary>
        /// <returns>true if the pump is running</returns>
        public bool IsRunning()
        {
            if (blnPumpRunning)
            {
                return true;
            } else
            {
                return false;
            }
        }

        /// <summary>
        /// Retrieves the pump status
        /// </summary>
        /// <returns>true if the pump is stopped</returns>
        public bool IsStopped()
        {
            if (blnPumpRunning)
            {
                return false;
            } else
            {
                return true;
            }
        }
    }
}
