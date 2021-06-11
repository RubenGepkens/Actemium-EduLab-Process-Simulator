/* EduLab-Proces-Sumulator - Leveltransmitter.cs
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
