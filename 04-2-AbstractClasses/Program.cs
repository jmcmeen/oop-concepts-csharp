namespace _04_AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> list = new List<Animal>();

            //list.Add(new Animal("Larry"));
            list.Add(new Cat("William"));
            list.Add(new Dog("Gene"));


            foreach (Animal a in list)
            {
                a.MakeSound();
            }
        }
    }
}