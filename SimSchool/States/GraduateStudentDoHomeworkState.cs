using System;

namespace SimSchool
{
    class GraduateStudentDoResearchState : IGraduateStudentState
    {

        public virtual void OnEnter(GraduateStudent inhabitant)
        {
            Console.WriteLine("Oh oh better get started.");
        }

        public virtual void Execute(GraduateStudent inhabitant)
        {
            inhabitant.Display("{{read, study, read study}} doing research....");
            inhabitant.ChangeState(new GraduateStudentSleepState());
        }

        public virtual void OnExit(GraduateStudent inhabitant)
        {
            Console.WriteLine("{{arrgghhhh}} Nothing is working!");
        }
    }
}