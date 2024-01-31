namespace _03_3_Aggregation
{
    /// <summary>
    /// An explanation of the Aggregation relationship
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //Assocation relationships that refers to encapsulation are called "has-a" relationships
            //It means that beyond just a class using another class to do something, that
            //the object of one class holds, or "has a," field or property of another class type

            //In this example a Person object "has-a" Address object as one of its properties
            //The term Aggregation is a specific case of "has-a" relationship which
            //implies that the containing object, Person, does not control the lifespan, 
            //of the reference to Address. An Address object can live
            //independently of Person object that contains it. Here we create an Address in main
            //and give it to a Person. Since the object Address was created in Program,
            //Program will still have a reference to the object when Person is no longer
            //in memory.

            //Let's create an Address
            Address address = new Address("2425 TN-75", "", "Blountville", "TN", "37617");

            //Now create a Person object
            Person person = new Person("John M.", address);

            //So we gave the Person object an Address, but what will happen when the Person
            //object "dies", or goes out of memory. We will set the Person object to null
            //to say to C#, we don't need that memory anymore, the reference points to nothing.
            //The memory management system in .NET will destroy the Person object so
            //the memory it utilized will be available again to other processes.
            person = null;

            //However, the Address object still lives on in memory! Let's print it.
            Console.WriteLine($"{address.Line1}\n{address.Line2}\n{address.City}\n{address.State}\n{address.Zip}");

            //And if you try to reference something with the "person" variable
            //the program will crash because it no longer exists and the reference
            //is said to be a null reference. I left this commented out, so it won't break.
            //You could uncomment this line and run it to see what happens.

            //person.Name;

            //Another thing to note is that it is most certainly an Aggregation relationship
            //If a contained object can belong to more than one object, such as below.
            //This is pretty much true for any container object that receives a reference
            //to an object through a method (as below), or a container object that allows
            //public access to the object it contains, such a get property or a getter method.
            person = new Person("John N.", address);
            Person person2 = new Person("Dave B.", address);

            Console.WriteLine();
            //At this point, there are 2 Persoon objects, and this class method (Main), that "has a"
            //reference to the Address object. Now, of course, when Main ends, all memory is released
            //back to the operating system.

            //Take aways:
            //Aggregation is a special type of Association
            //Aggregation is referred to as a "has-a" relationship in which the
            //container object does not explicitly manage the lifetime of 
            //an object it contains because that object can exist independently of the
            //container object.
        }
    }
}