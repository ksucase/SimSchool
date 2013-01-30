
namespace SimSchool
{
    public class ProfessorGradeHomeworkState : IProfessorState
    {

        public virtual void OnEnter(Professor inhabitant)
        {
            inhabitant.Display("{{Getting started grading.}}");
        }

        public virtual void Execute(Professor inhabitant)
        {
            inhabitant.Display("{{work work}} Grading papers.");
            inhabitant.ChangeState(new ProfessorSleepState());
        }

        public virtual void OnExit(Professor inhabitant)
        {
            inhabitant.Display("{{Smile}} Awesome students.");
        }
    }
}