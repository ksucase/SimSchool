using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimSchool
{
    class ProgrammerProgramState : IProgrammerState
    {
        private static int counter = 0;

        public virtual void OnEnter(Programmer inhabitant)
        {
            Console.WriteLine("Oh boy! It's time to work! :-)");
        }

        public virtual void Execute(Programmer inhabitant)
        {
            inhabitant.Display("{click clack, click clack} programming like a boss...");

            if (counter == 0)
            {
                inhabitant.ChangeState(new ProgrammerDrinkSodaState());
                counter++;
            }
            else
            {
                inhabitant.ChangeState(new ProgrammerSleepState());
                counter = 0;
            }
        }

        public virtual void OnExit(Programmer inhabitant)
        {
            Console.WriteLine("My code's not compiling!!!!!1!");
        }
    }
}
