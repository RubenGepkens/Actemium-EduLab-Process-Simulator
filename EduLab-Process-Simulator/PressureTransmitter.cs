/* EduLab-Proces-Sumulator - PressureTransmitter.cs
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
    public class PressureTransmitter
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
        /// <returns>Float with the pressure in hectopascals.</returns>
        public float GetPressure()
        {
            return tank.GetPressure() / 100;
        }
    }
}
