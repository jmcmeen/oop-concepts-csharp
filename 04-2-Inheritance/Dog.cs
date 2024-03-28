namespace _04_2_Inheritance
{
    /// <summary>
    /// Models a Dog derived from Animal
    /// </summary>
    internal class Dog : Animal
    {
        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="name">Dog's name</param>
        public Dog(string name) : base(name)
        {
        }

        /// <summary>
        /// Makes a Dog sound
        /// </summary>
        public override void MakeSound()
        {
            Console.WriteLine($"My name is {Name} and I go Woof!");
        }
    }
}
