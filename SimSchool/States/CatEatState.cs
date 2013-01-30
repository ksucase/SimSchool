using System;

namespace SimSchool
{
    /// <summary>
    /// A class that describes the cat's behavior 
    /// in the "Eat" state.
    /// </summary>
    class CatEatState  : ICatState
    {

        public virtual void OnEnter(Cat inhabitant)
        {
            Console.WriteLine("I can haz cheezburger? Pleez?");
        }

        /// <summary>
        /// Activities when executing this state including
        /// what state to transition to at the end.
        /// </summary>
        /// <param name="inhabitant">inhabitant</param>
        public virtual void Execute(Cat inhabitant)
        {
            inhabitant.Display("...nom nom nom....");
            inhabitant.ChangeState(new CatSleepState());  // move to cat's sleep state
        }

        public virtual void OnExit(Cat inhabitant)
        {
            Console.WriteLine("{{smilez}} That waz gud.");
        }
    }
}