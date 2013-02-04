
namespace SimSchool
{
    public class ProfessorGradeHomeworkState : IProfessorState
    {

        public void OnEnter(Professor inhabitant)
        {
            inhabitant.Display("{{Getting started grading.}}");
        }

        public void Execute(Professor inhabitant)
        {
            inhabitant.Display("{{work work}} Grading papers.");
            inhabitant.ChangeState(new ProfessorSleepState());
        }

        public void OnExit(Professor inhabitant)
        {
            inhabitant.Display("{{Smile}} Awesome students.");
        }
    }
}