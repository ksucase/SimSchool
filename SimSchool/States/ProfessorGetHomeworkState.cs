
namespace SimSchool
{
    public class ProfessorGetHomeworkState : IProfessorState
    {

        public virtual void OnEnter(Professor inhabitant)
        {
            inhabitant.Display("Oh my, better get the new submissions!");
        }

        public virtual void Execute(Professor inhabitant)
        {
            inhabitant.Display("{{Yay}} Getting all the completed homework.");
            inhabitant.ChangeState(new ProfessorDrinkCoffeeState());
        }


        public virtual void OnExit(Professor inhabitant)
        {
            inhabitant.Display("{{Smile}} Looks good.");
        }
    }
}