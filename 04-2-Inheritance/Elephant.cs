namespace _04_2_Inheritance
{
    /// <summary>
    /// Models an Elephant derived from Animal
    /// </summary>
    internal class Elephant : Animal
    {
        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="name">Elephant's name</param>
        public Elephant(string name) : base(name) { }

        /// <summary>
        /// Makes an elephant sound
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine($"My name is {Name} and I go Toot Toot!");
        }
    }
}
