namespace _04_1_Inheritance
{
    /// <summary>
    /// Models an Animal
    /// </summary>
    internal class Animal
    {
        /// <summary>
        /// Animal Name
        /// </summary>
        protected String Name { get; set; }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="name">Animal's name</param>
        public Animal(string name)
        {
            Name = name;
        }

        /// <summary>
        /// Makes an animal sound
        /// </summary>
        public virtual void MakeSound()
        {
            Console.WriteLine($"My name is {Name} and I have no voice.");
        }
    }
}
