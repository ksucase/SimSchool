using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimSchool
{
    /// <summary>
    /// The programmer.
    /// </summary>
    class Programmer : AbstractInhabitant
    {
        private IProgrammerState currentState;

        public Programmer() { }

        public Programmer(string inputName)
            : base(inputName)
        {
            currentState = new ProgrammerProgramState();
        }

        public void ChangeState(IProgrammerState newState)
        {
            this.currentState = newState;
        }

        public override void Start()
        {
            base.Display("Awesome! Starting up...");

            currentState = new ProgrammerProgramState();
        }

        public override void Finish()
        {
            base.Display("That was fun! :D");
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
