using System;

namespace SimSchool
{
    /// <summary>
    /// The abstract base class for all inhabitants of 
    /// SimSchoool. 
    /// </summary>
    public abstract class AbstractInhabitant
    {
        /// <summary>
        /// Default constructor.
        /// </summary>
        public AbstractInhabitant() { }

        /// <summary>
        /// Constructor taking a single name parameter.
        /// </summary>
        /// <param name="inputName">The inhabitant's unique name.</param>
        public AbstractInhabitant(string inputName)
        {
            this.name = inputName;
        }

        /// <summary>
        /// Virtual Execute() method that every inhabitant must have.
        /// Must be overridden by the derived class.
        /// </summary>
        public virtual void Execute()
        {
        }

        /// <summary>
        /// Virtual Start() method that every inhabitant must have. 
        /// Must be overridden by the derived class.
        /// </summary>
        public virtual void Start()
        {
        }

        /// <summary>
        /// Virtual Finish() method that every inhabitant must have. 
        /// Must be overridden by the derived class.
        /// </summary>
        public virtual void Finish()
        {
        }

        /// <summary>
        /// Public default Display() method. 
        /// </summary>
        /// <param name="message">The message to display.</param>
        public void Display(string message)
        {
            Console.WriteLine(name + ": " + message);
        }


        /// <summary>
        /// The protected Name property provided for all derived classes.
        /// </summary>
        protected string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// The private name field.  
        /// 
        /// No other classes can access this memory location directly.
        /// </summary>
        private string name;

    }
}
