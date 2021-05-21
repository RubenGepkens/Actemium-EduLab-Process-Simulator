using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EduLab_Process_Simulator
{
    class FlowTransmitter
    {
        public string strFlowTransmitterName { get; set; }
        private Tank tank;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="strObjectName"></param>
        /// <param name="Itank"></param>
        public FlowTransmitter(string strObjectName, Tank Itank)
        {
            strFlowTransmitterName = strObjectName;
            tank = Itank;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public float GetFlow()
        {
            return 0F;
        }
    }
}
