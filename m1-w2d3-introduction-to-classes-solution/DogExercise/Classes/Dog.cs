using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechElevator.Classes
{
    /**
    * This class represents a dog that can sleep, wake, and make a sound, so it's pretty much like most dogs,
    * with a few essential methods missing. Thankfully.
    */
    public class Dog
    {
        

        /**
        * @return true if the dog is sleeping, otherwise false
        */
        public bool isSleeping = false;
        

        /**
        * @return "woof!" if the dog is awake, otherwise "Zzzz..."
        */
        public string MakeSound()
        {
            if (isSleeping)
            {
                return "Zzzzz...";
            }
            else
            {
                return "woof!";
            }
        }

        /**
        * Puts the dog to sleep
        */
        public void Sleep()
        {
            isSleeping = true;
        }

        /**
        * Wakes the dog up
        */
        public void WakeUp()
        {
            isSleeping = false;
        }


    }
}
