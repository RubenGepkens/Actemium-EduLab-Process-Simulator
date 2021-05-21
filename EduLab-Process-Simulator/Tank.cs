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
        public float fltPressure { get; set; }

        /// <summary>
        /// Default constructor for a simulated tank.
        /// </summary>
        /// <param name="strObjectName">Name of this object</param>
        /// <param name="ItankCapacity">The capacity of the tank</param>
        public Tank(string strObjectName, float ItankCapacity)
        {
            strTankName = strObjectName;
            fltTankCapacity = ItankCapacity;
            fltTankVolume = 0;

            // No rates specified in this default constructor.
            fltFillRate = 0;
            fltEmptyRate = 0;
            fltPressure = 0;
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
            fltPressure         = 0;
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
        /// 
        /// </summary>
        public void FillTank()
        {
            float fltResult = fltTankVolume + fltFillRate;

            if (fltResult < fltTankCapacity)
            {
                fltTankVolume = fltResult;
            } else
            {
                fltTankVolume = fltTankCapacity;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void EmptyTank()
        {
            float fltResult = fltTankVolume - fltEmptyRate;

            if (fltResult < 0)
            {
                fltTankVolume = 0;
            }
            else
            {
                fltTankVolume = fltTankCapacity;
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
    }
}
