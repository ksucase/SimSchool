
namespace SimSchool
{
    /// <summary>
    /// A Professor type in the virtual world, derived
    /// from the AbstractInhabitant class.
    /// </summary>
    public class Professor : AbstractInhabitant
    {
        private IProfessorState currentState;

        public Professor() { }

        public Professor(string inputName)
        {
            base.Name = inputName;
            this.currentState = new ProfessorGetHomeworkState();  // default state is "get homework"
        }

        public void ChangeState(IProfessorState newState)
        {
            this.currentState = newState;
        }

        public override void Start()
        {
            base.Display("Hello, World!  Starting up.....");
            this.currentState = new ProfessorGetHomeworkState();  // start in "get homework"
        }

        public override void Finish()
        {
            base.Display("Great job - see you next time!");
        }
 
        private void OnEnter()
        {
            this.currentState.OnEnter(this);
        }

        public override void Execute()
        {
            this.currentState.Execute(this);
        }

        private void OnExit()
        {
            this.currentState.OnExit(this);
        }
       
    }
}
