using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduLab_Process_Simulator
{
    public class Tank
    {
        public string tankName { get; set; }
        public long tankVolume { get; private set; }
        public long tankCapacity { get; private set; }
        public long incomingVolume { get; set; }
        public long outgoingVolume { get; set; }

        public Tank(long ItankCapacity)
        {            
            tankCapacity = ItankCapacity;
            tankVolume = 0;
        }

        public void cycle()
        {
            tankVolume = tankVolume + (incomingVolume - outgoingVolume);
            Console.WriteLine("{0}: volume {1}", tankName, tankVolume);
        }
    }
}
