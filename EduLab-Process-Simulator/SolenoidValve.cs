using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduLab_Process_Simulator
{
    public class SolenoidValve
    {
        public string strNameTEST { get; set; }

        /*
        public SolenoidValve(string strName)
        {
            Console.WriteLine("Made instance for {0}", strName);
        }
        */

        public SolenoidValve()
        {

        }

        public string getName()
        {
            return strNameTEST;
        }

    }
}
