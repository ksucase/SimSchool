
namespace SimSchool
{
    /// <summary>
    /// An interface for Graduate Student states. 
    /// 
    /// Each method takes one argument of this inhabitant type.
    /// </summary>
    interface IGraduateStudentState
    {
        void OnEnter(GraduateStudent inhabitant);

        void Execute(GraduateStudent inhabitant);

        void OnExit(GraduateStudent inhabitant);
    }
}
