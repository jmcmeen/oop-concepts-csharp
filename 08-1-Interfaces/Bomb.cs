namespace _08_1_Interfaces
{
    internal class Bomb : IMakeSound
    {
        public void MakeSound()
        {
            Console.WriteLine("BOOM!");
        }
    }
}
