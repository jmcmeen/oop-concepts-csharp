namespace _08_1_Interfaces
{
    /// <summary>
    /// Models a Car that implements the ISound interface
    /// </summary>
    internal class Car : ISound
    {
        /// <summary>
        /// Makes a car sound
        /// </summary>
        public void MakeSound()
        {
            Console.WriteLine("Vrrroooom!");
        }
    }
}
