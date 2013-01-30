
namespace SimSchool
{
    /// <summary>
    /// A Cat type in the virtual world, derived
    /// from the AbstractInhabitant class.
    /// </summary>
    class Cat : AbstractInhabitant
    {
        private ICatState currentState;

        public Cat() { }

        public Cat(string inputName)
        {
            base.Name = inputName;
            this.currentState = new CatSleepState();  // default to sleep state
        }

        public void ChangeState(ICatState newState)
        {
            this.currentState = newState;
        }

        public override void Start()
        {
            base.Display("Oh hai!  Starting up......");
            this.currentState = new CatSleepState();  // start in sleep state
        }

        public override void Finish()
        {
            base.Display("Oh bye!");
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