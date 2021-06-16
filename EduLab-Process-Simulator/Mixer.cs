/* EduLab-Proces-Sumulator - Tank.cs
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
    public class Mixer
    {
        public string strMixerName { get; set; }
        public bool blnRunning { get; set; }

        /// <summary>
        /// Default constructor for a mixer.
        /// </summary>
        /// <param name="strObjectName"></param>
        public Mixer(string strObjectName)
        {
            strMixerName = strObjectName;
        }

        /// <summary>
        /// Starts the mixer.
        /// </summary>
        public void Start()
        {
            blnRunning = true;
        }

        /// <summary>
        /// Stops the mixer.
        /// </summary>
        public void Stop()
        {
            blnRunning = false;
        }

        /// <summary>
        /// Retrieves wether the mixer is running.
        /// </summary>
        /// <returns>true if running</returns>
        public bool IsRunning()
        {
            if (blnRunning)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Retrieves wether the mixer is stopped.
        /// </summary>
        /// <returns>true if stopped.</returns>
        public bool IsStopped()
        {
            if (blnRunning)
            {
                return false;
            } else
            {
                return true;
            }
        }
    }
}
