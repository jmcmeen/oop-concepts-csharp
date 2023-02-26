/// File: Program.cs
/// Name: John McMeen
/// Email: jnmcmeen@northeaststate.edu
/// Project: CISP 1020 Examples
namespace _01_Objects
{
    /// <summary>
    /// Program to demonstrate use of Classes and Objects
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a Loot reference
            Loot loot;

            // Instantiate a Loot object using new keyword and default constructor
            loot = new Loot();

            // Instantiate a new Loot obect using parameterized constructor
            Loot loot2 = new Loot("Hammer of Fate", 500);

            // Print to console, Loot object is converted to a String with .ToString() in Loot
            Console.WriteLine(loot);
            Console.WriteLine(loot2);

            // Use setter (mutator) methods to change objects
            loot.SetName("Sword of Truth");
            loot.SetPrice(250);
            loot2.SetPrice(750);

            // Print to console to see changes in Loot object
            Console.WriteLine(loot);
            Console.WriteLine(loot2);

            // Loot fields can be accessed using getter(accessor) methods
            Console.WriteLine($"You found a {loot2.GetName()} worth {loot2.GetPrice()} copper!");
        }
    }
}