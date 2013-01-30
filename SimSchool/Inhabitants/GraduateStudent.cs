
namespace SimSchool
{
    /// <summary>
    /// A GraduateStudent type in the virtual world, derived
    /// from the AbstractInhabitant class.
    /// </summary>
    class GraduateStudent : AbstractInhabitant
    {
        private IGraduateStudentState currentState;

        public GraduateStudent() { }

        public GraduateStudent(string inputName)
        {
            base.Name = inputName;
            this.currentState = new GraduateStudentDoResearchState();
        }

        public void ChangeState(IGraduateStudentState newState)
        {
            this.currentState = newState;
        }

        public override void Start()
        {
            base.Display("What??  Starting up......");
            this.currentState = new GraduateStudentSleepState();
        }

        public override void Finish()
        {
            base.Display("What?? It's over? So soon?");
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