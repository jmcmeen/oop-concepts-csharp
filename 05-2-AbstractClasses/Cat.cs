namespace _05_2_AbstractClasses
{
    /// <summary>
    /// Models a Cat derived from Animal
    /// </summary>
    internal class Cat : Animal
    {
        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="name">Cat's name</param>
        public Cat(string name) : base(name)
        {
        }

        /// <summary>
        /// Make a Cat sound
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine($"My name is {Name} and I go Meow!");
        }
    }
}
