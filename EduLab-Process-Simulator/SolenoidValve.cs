using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduLab_Process_Simulator
{
    public class SolenoidValve
    {
        public string svValveName { get; set; }
        public bool svValveStatus { get; set; }

        public SolenoidValve()
        {

        }

        public bool setStatus(bool svOpenClose)
        {
            if (svOpenClose == true)
            {
                svValveStatus = true;
            }
            else
            {
                svValveStatus = false;
            }

            return svValveStatus;
        }

        public bool getStatus()
        {
            Console.WriteLine("{0}: is {1}", svValveName, svValveStatus);
            return svValveStatus;
        }

    }
}
