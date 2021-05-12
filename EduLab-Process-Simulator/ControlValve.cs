using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduLab_Process_Simulator
{
    public class ControlValve
    {
        public string cvValveName { get; set; }
        public int cvValveStatus { get; set; }

        public ControlValve()
        {

        }

        public int setStatus(bool cvOpenClose)
        {
            if (cvOpenClose == true)
            {
                cvValveStatus = 100;
            }
            else
            {
                cvValveStatus = 0;
            }

            return cvValveStatus;
        }

        public int getStatus()
        {
            Console.WriteLine("{0}: is {1}", cvValveName, cvValveStatus);
            return cvValveStatus;
        }
    }
}
