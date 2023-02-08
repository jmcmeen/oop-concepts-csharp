namespace _04_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> list = new List<Animal>();

            Cat c = new Cat("Jeff");

            list.Add(new Animal("Larry"));
            list.Add(new Cat("William"));
            list.Add(new Dog("Gene"));
            list.Add(new Fish("Gerald"));
            list.Add(new Elephant("Thomas"));

            foreach (Animal a in list)
            {
                a.MakeSound();
            }
        }
    }
}