namespace _04_2_AbstractClasses
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
        public Elephant(string name) : base(name)
        {
        }

        /// <summary>
        /// Makes an Elephant sound
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine("As I said before, toot toot!");
        }
    }
}
