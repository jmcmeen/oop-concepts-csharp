namespace _03_4_Composition
{
    /// <summary>
    /// An explanation of the Composition relationship
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //Association relationships that refer to encapsulation are called "has-a" relationships
            //It means that beyond just a class using another class to do something, that
            //the object of one class holds, or "has a," field or property of another class type.

            //In this example a Car object "owns-a" Engine object as one of its fields
            //The term Composition is a specific case of "owns-a" relationship which
            //implies that the containing object, Car, owns complete control over the lifespan, 
            //or solely owns, the reference to Engine. An Engine object cannot live
            //independently of the Car object that contains it.

            //Here we create a Car object in main, and Car creates its own Engine. There is
            //no way to reference that Engine directly from another object or method, because
            //it is a private field in Car. The Car manages the Engine solely.

            Car? c = new Car();

            Console.WriteLine(c);
            c.EngineOn();
            Console.WriteLine(c);
            c.EngineOff();
            Console.WriteLine(c);

            //Because Car is only object that contains a reference to a specific Engine object,
            //when the Car is removed from memory, so too is the Engine.
            c = null;

            //Please do not mistake this relationship to mean that only Cars can contain Engines, other objects
            //can use the Engine class in any manner of the relationships described (aggregation or composition). 
            //Composition means the Car will manage the existence of its own Engine solely, and not give access to
            //the Engine publicly.

            //Take aways:
            //Composition is a special type of Association
            //Composition is referred to as a "has-a" relationship in which the
            //container object explicitly manages the lifetime of 
            //an object it contains because the object referenced cannot exist
            //independently of the container.
        }
    }
}