using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /*
    * his class represents an on/off switch. It turns on. It turns off. You can ask if its on or off.
    */
    public class Switch
    {
        //
        // Add any properties, along with getters and/or setters, that may be needed to implements the class methods.
        //

        public Switch()
        {

        }

        private bool isOn = false;
        /// <summary>
        /// Returns true if the switch is currently on, false if not
        /// </summary>        
        public bool IsOn
        {
            get
            {
                return isOn;
            }
        }


        /// <summary>
        /// Turns the switch on
        /// </summary>
        public void TurnOn()
        {
            isOn = true;
        }

        /// <summary>
        /// Turns the switch off
        /// </summary>
        public void TurnOff()
        {
            isOn = false;
        }

    }
}
