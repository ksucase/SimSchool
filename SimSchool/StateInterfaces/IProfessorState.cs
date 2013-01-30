
namespace SimSchool
{
    /// <summary>
    /// An interface for Professor states. 
    /// 
    /// Each method takes one argument of this inhabitant type.
    /// </summary>
    public interface IProfessorState
    {
        void OnEnter(Professor inhabitant );

        void Execute(Professor inhabitant);

        void OnExit(Professor inhabitant);
    }
}
