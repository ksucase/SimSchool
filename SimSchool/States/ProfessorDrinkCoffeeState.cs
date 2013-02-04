﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimSchool
{
    public class ProfessorDrinkCoffeeState : IProfessorState
    {

        public void OnEnter(Professor inhabitant)
        {
            inhabitant.Display("I need a cup of coffee.");
        }

        public void Execute(Professor inhabitant)
        {
            inhabitant.Display("{{sllluuurrrppp}} Umm Umm coffee's good.");
            inhabitant.ChangeState(new ProfessorGradeHomeworkState());
        }

        public void OnExit(Professor inhabitant)
        {
            inhabitant.Display("{{bright eyed}} Ready for work.");
        }
    }
}