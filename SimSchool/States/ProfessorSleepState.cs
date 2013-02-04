
namespace SimSchool
{
    public class ProfessorSleepState : IProfessorState
    {

        public void OnEnter(Professor inhabitant)
        {
            inhabitant.Display("{{Yawn}} Going to sleep.");
        }

        public void Execute(Professor inhabitant)
        {
            inhabitant.Display("{{dreaming}} ZZZzzzz  ZZZZZzzzz ");
            inhabitant.ChangeState(new ProfessorGetHomeworkState());
        }

        public void OnExit(Professor inhabitant)
        {
            inhabitant.Display("{{Smile}} What a beautiful day!");
        }
    }
}
