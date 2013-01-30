using System;

namespace SimSchool
{
    class GraduateStudentSleepState : IGraduateStudentState
    {

        public void OnEnter(GraduateStudent inhabitant)
        {
            Console.WriteLine("{{Yawn}} I need some sleep.");
        }

        public void Execute(GraduateStudent inhabitant)
        {
            inhabitant.Display("{{snoozing}}  ZZzzz ZZZzzz ");
            inhabitant.ChangeState(new GraduateStudentDoResearchState());
        }

        public void OnExit(GraduateStudent inhabitant)
        {
            Console.WriteLine("{{zzz}} What! Morning already!");
        }
    }
}