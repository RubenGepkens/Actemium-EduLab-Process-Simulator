using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduLab_Process_Simulator
{
    public class processCel
    {
        public Tank ta02 = new Tank(50);
        public Tank ta03 = new Tank(125);
        public Tank ta04 = new Tank(50);

        public ControlValve cv04 = new ControlValve();
        public ControlValve cv02 = new ControlValve();
        public ControlValve sv40 = new ControlValve(); // <- is eigenlijk een Solenoid valve!

        public processCel()
        {
            ta02.tankName = "TA02";
            ta03.tankName = "TA03";
            ta04.tankName = "TA04";

            cv04.valveName = "CV04";
            cv02.valveName = "CV02";
            sv40.valveName = "SV40";
        }

        public void cycle()
        {
            ta02.cycle();
            ta03.cycle();
            ta04.cycle();
        }
    }
}
