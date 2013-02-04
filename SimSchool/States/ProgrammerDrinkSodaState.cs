using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimSchool
{
    class ProgrammerDrinkSodaState : IProgrammerState
    {
        public virtual void OnEnter(Programmer inhabitant)
        {
            Console.WriteLine("I love drinking soda!");
        }

        public virtual void Execute(Programmer inhabitant)
        {
            inhabitant.Display("{gulp gulp} That was delicious!");
            inhabitant.ChangeState(new ProgrammerProgramState());
        }

        public virtual void OnExit(Programmer inhabitant)
        {
            Console.WriteLine("Sweet. Now I'm ready to program!");
        }
    }
}
