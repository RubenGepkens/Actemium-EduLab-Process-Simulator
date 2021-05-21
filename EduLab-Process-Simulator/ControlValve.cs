using System;

namespace EduLab_Process_Simulator
{
    public class ControlValve
    {
        public string strValveName { get; set; }
        public int intValvePosition { get; set; }

        /// <summary>
        /// Simulated control valve.
        /// </summary>
        public ControlValve()
        {

        }

        /// <summary>
        /// Simulated control valve.
        /// </summary>
        /// <param name="strObjectName"></param>
        public ControlValve(string strObjectName)
        {

        }

        /// <summary>
        /// Commands the valve to take the given position as commanded by the input.
        /// </summary>
        /// <param name="intCommandValue"></param>
        public void commandValve(int intCommandValue)
        {
            // If the commanded valvue is out of bounds, ignore the command.
            if ( intCommandValue < 0 || intCommandValue > 100)
            {
                return;
            } else
            {
                // At this moment the opening and closing of the valve is not simulated.
                // Therefore the valve will take the requested position immediately. 
                intValvePosition = intCommandValue;
            }
        }

        /// <summary>
        /// Returns the status of the valve.
        /// </summary>
        /// <returns>Returns a number between 0% and 100% where 0% means a fully closed valve and 100% means a fully opened valve.</returns>
        public int getStatus()
        {
            Console.WriteLine("{0}: is {1}", strValveName, intValvePosition);
            return intValvePosition;
        }
    }
}
