namespace _06_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> list = new List<IAnimal>();
            
            Cat cat = new Cat();
            Dog dog = new Dog();

            list.Add(cat);
            list.Add(dog);

            foreach(IAnimal animal in list)
            {
                animal.MakeSound();
            }
        }
    }
}