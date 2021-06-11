/* EduLab-Proces-Sumulator - SolenoidValve.cs
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
    public class SolenoidValve
    {
        public string strValveName { get; set; }
        public int intValvePosition { get; set; }

        /// <summary>
        /// Simulated solenoid valve.
        /// </summary>
        public SolenoidValve()
        {
            intValvePosition = 0;
        }

        /// <summary>
        /// Simulated solenoid valve.
        /// </summary>
        /// <param name="strObjectName"></param>
        public SolenoidValve(string strObjectName)
        {
            strValveName = strObjectName;
            intValvePosition = 0;
        }

        /// <summary>
        /// Opens the valve.
        /// </summary>
        public void OpenValve()
        {
            // At this moment the opening and closing of the valve is not simulated.
            // Therefore the valve will take the requested position immediately. 
            intValvePosition = 100;
        }

        /// <summary>
        /// Closes the valve.
        /// </summary>
        public void CloseValve()
        {
            // At this moment the opening and closing of the valve is not simulated.
            // Therefore the valve will take the requested position immediately. 
            intValvePosition = 0;
        }

        /// <summary>
        /// Returns wheter the valve is opened or not.
        /// </summary>
        /// <returns>True if the valve is open or False if it is closed.</returns>
        public bool IsOpen()
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
        public bool IsClosed()
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
