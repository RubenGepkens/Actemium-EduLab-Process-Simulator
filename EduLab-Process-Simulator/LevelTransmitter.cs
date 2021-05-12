using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduLab_Process_Simulator
{
    public class Leveltransmitter
    {
        public string levelTransmitterName { get; set; }
        public int levelTransmitterValue { get; set; }

        public Leveltransmitter()
        {

        }

        public int getStatus()
        {
            Console.WriteLine("{0}: is {1}", levelTransmitterName, levelTransmitterValue);
            return levelTransmitterValue;
        }

    }
}
