namespace _06_1_Interfaces
{
    /// <summary>
    /// Demonstrates a custom interface
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //We can create a list of object that implement ISound, in a polymorphic way
            List<ISound> list = new List<ISound>();
            
            //Cats and Cars are very different objects
            Cat cat = new Cat();
            Car car = new Car();

            //But this list doesn't care
            list.Add(cat);
            list.Add(car);

            //Because they all make sound
            foreach(ISound thingThatMakesSounds in list)
            {
                Console.WriteLine(thingThatMakesSounds.GetType());
                thingThatMakesSounds.MakeSound();
            }
        }
    }
}