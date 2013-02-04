
namespace SimSchool
{
    public class ProfessorGetHomeworkState : IProfessorState
    {

        public void OnEnter(Professor inhabitant)
        {
            inhabitant.Display("Oh my, better get the new submissions!");
        }

        public void Execute(Professor inhabitant)
        {
            inhabitant.Display("{{Yay}} Getting all the completed homework.");
            inhabitant.ChangeState(new ProfessorDrinkCoffeeState());
        }


        public void OnExit(Professor inhabitant)
        {
            inhabitant.Display("{{Smile}} Looks good.");
        }
    }
}