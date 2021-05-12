using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduLab_Process_Simulator
{
    public class Pump
    {
        public string pumpName { get; set; }
        public bool pumpStatus { get; set; }

        public Pump()
        {            
            
        }

        public bool setStatus(bool pumpOnOff)
        {
            if (pumpOnOff == true)
            {
                pumpStatus = true;
            }
            else
            {
                pumpStatus = false;
            }
            return pumpOnOff;
        }

        public bool getStatus()
        {
            Console.WriteLine("{0}: is {1}", pumpName, pumpStatus);
            return pumpStatus;
        }


    }
}
