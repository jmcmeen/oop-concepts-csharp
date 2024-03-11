namespace _04_2_AbstractClasses
{
    /// <summary>
    /// Program demonstrating abstract classes
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //create a list of generic, abstract, type Animal
            List<Animal> list = new List<Animal>();

            //If you uncomment the line below, you will see you can not instantiate an abstract type
            //list.Add(new Animal("Larry"));

            //Instantiate concrete types and add to a List
            list.Add(new Cat("Sir Bill III"));
            list.Add(new Dog("Darby"));
            list.Add(new Donkey("Daniela"));
            list.Add(new Elephant("Elizabeth"));
            list.Add(new Fish("Frederick"));

            //Make them make sound!
            foreach (Animal a in list)
            {
                a.MakeSound();
            }
        }
    }
}