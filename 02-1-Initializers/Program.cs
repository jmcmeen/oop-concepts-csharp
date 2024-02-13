// File: Program.cs
// Name: John McMeen
// Email: jnmcmeen@northeaststate.edu
// Project: CISP 1020 Examples
// Notes: Based on example at https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-initialize-objects-by-using-an-object-initializer
namespace _01_Initializers
{
    internal class Program 
    {
        static void Main()
        {
            // Declare a Loot by using the constructor that has two parameters.
            Loot loot1 = new Loot("Sword", 20);

            // Make the same declaration by using an object initializer and sending
            // arguments for the first and last names. The parameterless constructor is
            // invoked in processing this declaration, not the constructor that has
            // two parameters.
            Loot loot2 = new Loot
            {
                Name = "Mace",
                Price = 25
            };

            // Declare a Loot by using an object initializer and sending
            // an argument for only the ID property. No corresponding constructor is
            // necessary. Only the parameterless constructor is used to process object
            // initializers.
            Loot loot3 = new Loot()
            {
                Name = "Dagger"
            };

            // Declare a Loot by using an object initializer and sending
            // arguments for all three properties. No corresponding constructor is
            // defined in the class.
            Loot loot4 = new Loot
            {
                Name = "Staff",
                Price = 50,
                Description = "woo!"
            };

            Console.WriteLine(loot1);
            Console.WriteLine(loot2);
            Console.WriteLine(loot3);
            Console.WriteLine(loot4);
        }
    }
}