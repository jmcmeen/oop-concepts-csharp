namespace _04_2_AbstractClasses
{
    /// <summary>
    /// Models an abstract Animal
    /// </summary>
    internal abstract class Animal
    {
        //public auto-implemented properties
        protected String Name { get; set; }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="name"></param>
        public Animal(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Make an animal sound
        /// </summary>
        public abstract void MakeSound();
    }
}
