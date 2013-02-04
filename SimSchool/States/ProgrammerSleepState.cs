using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimSchool
{
    class ProgrammerSleepState : IProgrammerState
    {
        public virtual void OnEnter(Programmer inhabitant)
        {
            Console.WriteLine("I gotta fix this errorrr... zzZzzZZz...");
        }

        public virtual void Execute(Programmer inhabitant)
        {
            inhabitant.Display("...zZzzZzZ (dreaming of attacking the evil computer bugs, like a boss) zzzZzZ...");
            inhabitant.ChangeState(new ProgrammerProgramState());
        }

        public virtual void OnExit(Programmer inhabitant)
        {
            Console.WriteLine("...zZzzz oh my, what time is it?!");
        }
    }
}
