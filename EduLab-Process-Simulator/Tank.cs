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
    public class Tank
    {
        public string strTankName { get; set; }
        public float fltTankVolume { get; set; }
        public float fltTankCapacity { get; set; }
        public float fltFillRate { get; set; }
        public float fltEmptyRate { get; set; }
        public float fltChangeRate { get; set; }
        public float fltPressure { get; set; }
        public float fltTemperature { get; set; }

        /// <summary>
        /// Default constructor for a simulated tank.
        /// </summary>
        /// <param name="strObjectName">Name of this object</param>
        /// <param name="ItankCapacity">The capacity of the tank</param>
        public Tank(string strObjectName, float ItankCapacity)
        {
            strTankName         = strObjectName;
            fltTankCapacity     = ItankCapacity;
            fltTankVolume       = 0F;

            // No rates specified in this default constructor.
            fltFillRate         = 0F;
            fltEmptyRate        = 0F;
            fltPressure         = 101325F;         // ISA pressure at sea-level equal 101325 pascal [Pa]
            fltTemperature      = 0F;
        }

        /// <summary>
        /// Creates a simulated tank with specified initial volume.
        /// </summary>
        /// <param name="strObjectName">Name of this object</param>
        /// <param name="ItankCapacity">The capacity of the tank</param>
        /// <param name="ItankVolume">The initial volume of the tank</param>
        /// <param name="IfltFillRate"></param>
        /// <param name="IfltEmptyRate"></param>
        public Tank(string strObjectName, float ItankCapacity, float ItankVolume, float IfltFillRate, float IfltEmptyRate)
        {
            strTankName         = strObjectName;
            fltTankCapacity     = ItankCapacity;
            fltTankVolume       = ItankVolume;
            fltFillRate         = IfltFillRate;
            fltEmptyRate        = IfltEmptyRate;
            fltPressure         = 101325F;         // ISA pressure at sea-level equal 101325 pascal [Pa]
            fltTemperature      = 0F;
        }

        /// <summary>
        /// Returns the current volume of the tank.
        /// </summary>
        /// <returns>Float value between 0 and the tank capacity.</returns>
        public float GetVolume()
        {
            return fltTankVolume;
        }

        /// <summary>
        /// Fill the tank, calculate for one simulation cycle the level change.
        /// </summary>
        public void FillTank()
        {
            float fltResult = fltTankVolume + fltFillRate;

            if (fltResult < fltTankCapacity)
            {
                fltTankVolume = fltResult;
                fltChangeRate = fltFillRate;
            } else
            {
                fltTankVolume = fltTankCapacity;
                fltChangeRate = 0F;
            }
        }

        /// <summary>
        /// Empty the tank, calculate for one simulation cycle the level change.
        /// </summary>
        public void EmptyTank()
        {
            float fltResult = fltTankVolume - fltEmptyRate;

            if (fltResult > 0)
            {
                fltTankVolume = fltResult;
                fltChangeRate = fltEmptyRate;
            }
            else
            {
                fltTankVolume = 0;
                fltChangeRate = 0F;
            }
        }

        /// <summary>
        /// Returns the current pressure in the tank
        /// </summary>
        /// <returns>Float value that represents the pressure in pascal</returns>
        public float GetPressure()
        {
            return fltPressure;
        }

        /// <summary>
        /// Returns the current temperature in the tank
        /// </summary>
        /// <returns>Float value that represents the temperature in degrees celcius</returns>
        public float GetTemperature()
        {
            return fltTemperature;
        }

        /// <summary>
        /// Returns the tank status
        /// </summary>
        /// <returns>True if tank is full</returns>
        public bool IsFull()
        {
            if (fltTankVolume == fltTankCapacity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Returns the tank status
        /// </summary>
        /// <returns>True if tank is empty.</returns>
        public bool IsEmpty()
        {
            if (fltTankVolume == 0)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
