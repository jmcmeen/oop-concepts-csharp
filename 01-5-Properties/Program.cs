using LabUtils;

namespace _01_5_Properties
{
    /// <summary>
    /// Demonstrates object properties
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

            //Get the person's Name property and print it
            Console.WriteLine(person.NameAsPropertyWithExplicitField);

            //Investigating the person class shows the NameAsProperty property
            //hides a private field, _name, and exposes access
            //through get and set properties. Properties can be assigned and accessed
            //like variables or fields in an object. 

            //Set the person's Name property
            person.NameAsPropertyWithExplicitField = "Leroy Jenkins";

            //Get the person's Name property and print it
            Console.WriteLine(person.NameAsPropertyWithExplicitField);

            //The auto implemented property in Person behaves the same way,
            //but doesn't have any additional behavior
            person.NameAsAutoProperty = "Burf Snerfle";
            Console.WriteLine(person.NameAsAutoProperty);
        }
    }
}
