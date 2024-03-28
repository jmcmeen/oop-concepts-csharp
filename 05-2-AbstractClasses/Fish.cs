namespace _05_2_AbstractClasses
{
    /// <summary>
    /// Models a Fish derived from Animal
    /// </summary>
    internal class Fish : Animal
    {
        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="name">Fish's name</param>
        public Fish(string name) : base(name)
        {
        }

        /// <summary>
        /// Makes a Fish sound (none)
        /// </summary>
        public override void MakeSound()
        {
            //I'm a fish, bro. I don't make sound, but my parent says I have to implement this method
        }
    }
}
