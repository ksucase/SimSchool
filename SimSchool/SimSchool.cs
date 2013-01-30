using System;
using System.Collections.Generic;

namespace SimSchool
{
    /// <summary>
    /// SimSchool is a small virtual world where the simple inhabitants 
    /// go about their lives. 
    /// 
    /// The goal is to be able to enhance an existing object-oriented
    /// program that is new to you. Following the same naming patterns, 
    /// extend the project by adding a new type of
    /// inhabitant to the SimSchool world.
    /// 
    /// SimSchool begins with 3 inhabitants:
    /// 
    /// A Professor, whose life is spent in four states, endlessly 
    /// repeating the same four goals:  
    ///     Drink Coffee
    ///     Get Homework
    ///     Grade Homework
    ///     Sleep
    ///     
    /// A Cat, whose life is spent in two states, endlessly 
    /// repeating the same two goals:  
    ///     Eat
    ///     Sleep
    ///     
    /// A Graduate Student, whose life is spent in four states, endlessly 
    /// repeating the same four goals:  
    ///     Do Homework
    ///     Do Research
    ///     Write Papers
    ///     Sleep
    ///     
    /// 1. Create a new type of inhabitant, also derived from the AbstractInhabitant
    /// class. The abstract base class will provide the Name property, and 
    /// the ability to reside together in a List. 
    /// (Hint: see GraduateStudent.cs)
    /// 
    /// 2. Create a new Interface based on your inhabitant type. 
    /// Include 3 three method signatures that describe behavior when 
    /// first entering a state, while doing the state, and when finishing 
    /// the state:
    ///    void OnEnter
    ///    void Execute
    ///    void OnExit
    /// each of which takes your new inhabitant type as the single parameter. 
    /// (Hint: see IGraduateStudent.cs)
    /// 
    /// Create three or more custom states for your inhabitant that implement
    /// your new interface. (Hint: see GraduateStudentSleepState.cs)
    /// Explore the existing classes to see how the transitions between states
    /// are accomplished. 
    /// 
    /// In the main SimSchool program below, create an instance of your 
    /// new inhabitant type and add your character to the virtual world.
    /// 
    /// This simple virtual world uses a common pattern that has been 
    /// applied in many types of artificial intelligence and games.  
    /// 
    /// </summary>
    class SimSchool
    {
        static void Main(string[] args)
        {
            // set how long to run the virtual world
            const int NUMBER_OF_MOVES = 5;

            // start with an empty list of generic inhabitants
            List<AbstractInhabitant> inhabitantList = new List<AbstractInhabitant>();

            // add a new graduate student to the list
            GraduateStudent denise = new GraduateStudent("Graduate Student Denise");
            inhabitantList.Add(denise);

            // add a new professor instance to the list
            Professor profCase = new Professor("Prof Case");
            inhabitantList.Add(profCase);

            // add a new cat instance to the list
            Cat bill = new Cat("Bill the Cat");
            inhabitantList.Add(bill);

            // add a new type of character to the list

            //TODO: add your code here

            // startup each inhabitant on the list
            foreach (AbstractInhabitant inhabitant in inhabitantList)
            {
                inhabitant.Start();
            }

            //display a blank line just for readability
            Console.WriteLine();

            // run the virtual world
            for (int i = 0; i <= NUMBER_OF_MOVES; i++)
            {
                //display what move we're on
                Console.WriteLine(i);

                // have each inhabitant execute their updated state
                foreach (AbstractInhabitant inhabitant in inhabitantList)
                    inhabitant.Execute();

                //display a blank line just for readability
                Console.WriteLine();
            }

            // virtual world is winding down - have the inhabitants finish up
            foreach (AbstractInhabitant inhabitant in inhabitantList)
            {
                inhabitant.Finish();
            }

            // keep the command window open
            Console.Read();
        }
    }
}
