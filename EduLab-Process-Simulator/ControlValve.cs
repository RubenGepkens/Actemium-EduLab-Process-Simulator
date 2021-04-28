using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduLab_Process_Simulator
{
    public class ControlValve
    {
        public string valveName { get; set; }
        public bool valveStatus { get; set; }

        public ControlValve()
        {

        }

        public bool getStatus()
        {
            Console.WriteLine("{0}: is {1}", valveName, valveStatus);
            return valveStatus;
        }
    }
}
