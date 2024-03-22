namespace _06_1_Interfaces
{
    internal class Duck : ISound
    {
        public void MakeSound()
        {
            Console.WriteLine("Quack!");
        }
    }
}
