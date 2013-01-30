
namespace SimSchool
{
    /// <summary>
    /// An interface for Cat states. 
    /// 
    /// Each method takes one argument of this inhabitant type.
    /// </summary>
    interface ICatState
    {
        void OnEnter(Cat inhabitant);

        void Execute(Cat inhabitant);

        void OnExit(Cat inhabitant);
    }
}
