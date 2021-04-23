using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduLab_Process_Simulator
{
    class ControlValve
    {
        private string valveName;
        private bool valveStatus;

        public ControlValve(string IvalveName)
        {
            valveName = IvalveName;
        }

        public bool getStatus()
        {
            Console.WriteLine("{0}: is {1}", valveName, valveStatus);
            return valveStatus;
        }

        public void open()
        {
            valveStatus = true;
        }

        public void close()
        {
            valveStatus = false;
        }

    }
}
