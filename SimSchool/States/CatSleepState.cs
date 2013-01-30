using System;

namespace SimSchool
{
    /// <summary>
    /// A class that describes the cat's behavior 
    /// in the "Sleep" state.
    /// </summary>
    class CatSleepState : ICatState
    {
        /// <summary>
        /// Activities when first entering this state.
        /// </summary>
        /// <param name="inhabitant">inhabitant</param>
        public void OnEnter(Cat inhabitant)
        {
            Console.WriteLine("Iz tireds.");
        }

        /// <summary>
        /// Activities when executing this state including
        /// what state to transition to at the end.
        /// </summary>
        /// <param name="inhabitant">inhabitant</param>
        public void Execute(Cat inhabitant)
        {
            inhabitant.Display("{{ZZZZZ}} sleeping....");
            inhabitant.ChangeState(new CatEatState());   // move to cat's eat state
        }

        /// <summary>
        /// Activities when leaving this state.
        /// </summary>
        /// <param name="inhabitant"></param>
        public void OnExit(Cat inhabitant)
        {
            Console.WriteLine("{{Stretch}} Waking up.");
        }
    }
}