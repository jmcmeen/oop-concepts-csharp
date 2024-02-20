namespace _01_2_AutoProperties
{
    /// <summary>
    /// Program to demonstrate use of Classes and Objects
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            // Create a Loot reference
            Loot loot;

            // Instantiate a Loot object using new keyword and default constructor
            loot = new Loot();

            // Instantiate a new Loot object using parameterized constructor
            Loot loot2 = new Loot("Hammer of Fate", 500);

            // Print to console, Loot object is converted to a String with .ToString() in Loot
            Console.WriteLine(loot);
            Console.WriteLine(loot2);

            // Use Loot properties to change objects
            loot.Name = "Sword of Truth";
            loot.Price = 250;
            loot2.Price = 750;

            // Print to console to see changes in Loot object
            Console.WriteLine(loot);
            Console.WriteLine(loot2);

            // Loot fields can be accessed using properties
            Console.WriteLine($"You found a {loot2.Name} worth {loot2.Price} copper!");
        }
    }
}