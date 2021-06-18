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
    /// <summary>
    /// Class that contains the simulation properties of the process installation.
    /// Allows for storing all parameters in just one class.
    /// </summary>
    public class SimulationProperties
    {
        public float fltKE01_EmptyRate { get; set; }
        public float fltTA02_FillRate { get; set; }
        public float fltTA02_EmptyRate { get; set; }
        public float fltTA03_FillRate { get; set; }
        public float fltTA03_EmptyRate { get; set; }
        public float fltTA04_FillRate { get; set; }
        public float fltTA04_EmptyRate { get; set; }

        public SimulationProperties()
        {
            fltKE01_EmptyRate = 0.77F;
            fltTA02_FillRate = 0.54F;
            fltTA02_EmptyRate = 0.62F;
            fltTA03_FillRate = 0.86F;
            fltTA03_EmptyRate = 0.26F;
            fltTA04_FillRate = 0.48F;
            fltTA04_EmptyRate = 0.26F;
        }
    }
}
