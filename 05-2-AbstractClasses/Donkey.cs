namespace _04_2_AbstractClasses
{
    /// <summary>
    /// Models a Donkey derived from Animal
    /// </summary>
    internal class Donkey : Animal
    {
        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="name">Donkey's name</param>
        public Donkey(string name) : base(name)
        {

        }

        /// <summary>
        /// Makes a Donkey sound
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine("Blargle!");
        }
    }
}
