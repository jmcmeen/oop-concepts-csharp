namespace _08_1_Interfaces
{
    internal class Bomb : ISound
    {
        public void MakeSound()
        {
            Console.WriteLine("BOOM!");
        }
    }
}
