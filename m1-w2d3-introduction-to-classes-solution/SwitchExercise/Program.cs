using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechElevator.Classes;

namespace SwitchExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool allTestsPassed = true;

            /*** New switches are off ***/
            Switch mySwitch = new Switch();

            if (mySwitch.IsOn)
            {
                allTestsPassed = false;
                Console.WriteLine("Test 1 FAILED: A new switch should be off, but this one is on.");
            }

            /*** turnOn should turn the switch on ***/
            mySwitch.TurnOn();
            if (mySwitch.IsOn == false)
            {
                allTestsPassed = false;
                Console.WriteLine("Test 2 FAILED: A switch should be on after being turned on, but this one is not on.");
            }

            /*** turnOff should turn the switch off ***/
            mySwitch.TurnOff();
            if (mySwitch.IsOn)
            {
                allTestsPassed = false;
                Console.WriteLine("Test 3 FAILED: A switch should be off after being turned off, but this one is on.");
            }

            if (allTestsPassed)
            {
                Console.WriteLine("All tests PASSED!");
            }
        }
    }
}
