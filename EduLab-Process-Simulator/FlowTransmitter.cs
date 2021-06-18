/* EduLab-Proces-Sumulator - FlowTransmitter.cs
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
    public class FlowTransmitter
    {
        public string strFlowTransmitterName { get; set; }
        private Tank tank;
        private bool blnRelease;

        /// <summary>
        /// Default constructor for a flow transmitter.
        /// </summary>
        /// <param name="strObjectName"></param>
        /// <param name="Itank"></param>
        public FlowTransmitter(string strObjectName, Tank Itank)
        {
            strFlowTransmitterName = strObjectName;
            blnRelease = false;
            tank = Itank;
        }

        /// <summary>
        /// Sets the condition that all conditions are met for a flow to start in a pipe.
        /// Example; all valves and the pump is started in a pipe.
        /// </summary>
        public void Release()
        {
            blnRelease = true;
        }

        /// <summary>
        /// Sets the condition that all conditions are met for a flow to start in a pipe.
        /// Example; all valves and the pump is started in a pipe.
        /// </summary>
        public void Blocked()
        {
            blnRelease = false;
        }

        /// <summary>
        /// Gets the current flow.
        /// </summary>
        /// <returns>float with the flow.</returns>
        public float GetFlow()
        {
            if (blnRelease)
            {
                return tank.fltChangeRate;
            } else
            {
                return 0.00F;
            }            
        }
    }
}
