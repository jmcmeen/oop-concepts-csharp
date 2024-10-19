using LabUtils;

namespace _01_6_AutoProperties
{
    /// <summary>
    /// Program to demonstrate use of Auto
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            // create a person object
            Person person = new Person();

            //Investigating the person class shows the NameAsAutoProperty
            //simplifies the setup of a property. If the get and set properties 
            //do not need explicit functionality, a hidden field is implied, 
            //and will work just as before.

            //Set the person's Name property
            person.NameAsAutoProperty = "Leroy";

            //Get the person's Name property and print it
            Console.WriteLine(person.NameAsAutoProperty);

            //Loot has some auto-properties too!

            // Create a Loot reference
            Loot loot;

            // Instantiate a Loot object using new keyword and default constructor
            loot = new Loot();

            // Use Loot properties to change objects
            loot.Name = "Sword of Truth";
            loot.Price = 250;

            // Print to console to see changes in Loot object
            Console.WriteLine(loot);

            // Loot fields can be accessed using properties
            Console.WriteLine($"You found a {loot.Name} worth {loot.Price}!");
        }
    }
}