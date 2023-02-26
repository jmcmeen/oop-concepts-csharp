namespace _06_Interfaces
{
    /// <summary>
    /// Models a Cat that implements the ISound interface
    /// </summary>
    internal class Cat : ISound
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
