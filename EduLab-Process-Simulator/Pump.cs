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
            if pumpOnOff == 1
            {
                pumpStatus = 1;
            }
            else
            {
                pumpStatus = 0;
            }
        }

        public bool getStatus()
        {
            Console.WriteLine("{0}: is {1}", pumpName, pumpStatus);
            return pumpStatus;
        }


    }
}
