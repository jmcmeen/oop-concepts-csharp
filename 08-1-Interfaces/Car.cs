namespace _08_1_Interfaces
{
    /// <summary>
    /// Models a Car that implements the ISound interface
    /// </summary>
    internal class Car : IMakeSound
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
