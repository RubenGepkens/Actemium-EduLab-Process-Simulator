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
