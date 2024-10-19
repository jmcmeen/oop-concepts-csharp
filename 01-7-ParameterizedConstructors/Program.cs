using LabUtils;

namespace _01_7_ParameterizedConstructors
{
    /// <summary>
    /// Demonstrates parameterized constructors
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            // Instantiate a new Loot object using parameterized constructor
            Loot loot = new Loot("Hammer of Fate", 500, "This is an awesome hammer");

            // Print to console to see changes in Loot object
            Console.WriteLine(loot);

            // Loot fields can be accessed using properties
            Console.WriteLine($"You found a {loot.Name} worth {loot.Price}!" +
                $"The inscription reads {loot.Description}");
        }
    }
}
