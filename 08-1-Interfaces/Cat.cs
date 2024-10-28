namespace _08_1_Interfaces
{
    /// <summary>
    /// Models a Cat that implements the ISound interface
    /// </summary>
    internal class Cat : IMakeSound
    {
        /// <summary>
        /// Makes a Cat sound
        /// </summary>
        public void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }
}
