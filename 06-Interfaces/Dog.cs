namespace _06_Interfaces
{
    internal class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }
}
