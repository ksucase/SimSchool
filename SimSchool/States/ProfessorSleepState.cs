
namespace SimSchool
{
    public class ProfessorSleepState : IProfessorState
    {

        public virtual void OnEnter(Professor inhabitant)
        {
            inhabitant.Display("{{Yawn}} Going to sleep.");
        }

        public virtual void Execute(Professor inhabitant)
        {
            inhabitant.Display("{{dreaming}} ZZZzzzz  ZZZZZzzzz ");
            inhabitant.ChangeState(new ProfessorGetHomeworkState());
        }

        public virtual void OnExit(Professor inhabitant)
        {
            inhabitant.Display("{{Smile}} What a beautiful day!");
        }
    }
}
