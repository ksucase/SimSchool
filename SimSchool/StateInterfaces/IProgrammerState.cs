using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimSchool
{
    interface IProgrammerState
    {
        void OnEnter(Programmer inhabitant);
        void Execute(Programmer inhabitant);
        void OnExit(Programmer inhabitant);
    }
}
