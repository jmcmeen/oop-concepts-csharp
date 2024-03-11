namespace _04_1_Inheritance
{
    /// <summary>
    /// Program demonstrating basic inheritance and polymorphic behavior
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            List<Animal> list = new List<Animal>();

            Cat c = new Cat("Jeff");

            list.Add(new Animal("Larry"));
            list.Add(new Cat("William"));
            list.Add(new Dog("Gene"));
            list.Add(new Fish("Gerald B."));
            list.Add(new Elephant("Thomas"));

            foreach (Animal a in list)
            {
                a.MakeSound();
            }
        }
    }
}