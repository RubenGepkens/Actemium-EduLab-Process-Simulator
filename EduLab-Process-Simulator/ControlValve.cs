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
            intValvePosition = 0;
        }

        /// <summary>
        /// Simulated control valve.
        /// </summary>
        /// <param name="strObjectName"></param>
        public ControlValve(string strObjectName)
        {
            strValveName = strObjectName;
            intValvePosition = 0;
        }

        /// <summary>
        /// Opens the valve.
        /// </summary>
        public void OpenValve()
        {
            // At this moment the opening and closing of the valve is not simulated.
            // Therefore the valve will take the requested position immediately. 
            intValvePosition = 100;
        }

        /// <summary>
        /// Closes the valve.
        /// </summary>
        public void CloseValve()
        {
            // At this moment the opening and closing of the valve is not simulated.
            // Therefore the valve will take the requested position immediately. 
            intValvePosition = 0;
        }

        /// <summary>
        /// Commands the valve to take the given position as commanded by the input.
        /// </summary>
        /// <param name="intCommandValue"></param>
        public void CommandValve(int intCommandValue)
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
        /// Returns the position of the valve.
        /// </summary>
        /// <returns>Value between 0% and 100% indicating the opening of the valve.</returns>
        public int GetStatus()
        {
            //Console.WriteLine("{0}: is {1}", strValveName, blnValveStatus);
            return intValvePosition;
        }

        /// <summary>
        /// Returns wheter the valve is opened or not.
        /// </summary>
        /// <returns>True if the valve is open or False if it is closed.</returns>
        public bool IsOpen()
        {
            if (intValvePosition >= 95)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Returns wheter the valve is closed or not.
        /// </summary>
        /// <returns>True if the valve is closed or False if it is opened.</returns>
        public bool IsClosed()
        {
            if (intValvePosition <= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
