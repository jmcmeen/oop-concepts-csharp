namespace _06_1_Interfaces
{
    internal class Bomb : ISound
    {
        public void MakeSound()
        {
            Console.WriteLine("BOOM!");
        }
    }
}
