using SampleClasses;

namespace _04_5_Equals
{
    /// <summary>
    /// Demonstrates Equals
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {

            //Investigating the Equals method in the Loot class, we see it
            //is overridden to compare all fields.

            //In general the Equals method will check 4 things:
            // 1. Is the reference passed in null? (it will return false if the reference passed in is null)
            // 2. The type of the object (if not the same type, it will return false)
            // 3. Is the reference passed in the same object? (this means it is the same object, identical, not just equal)
            // 4. The values of each field (if all fields are equal, it will return true)


            //Let's create some Loot objects
            Loot loot1 = new Loot
            {
                Name = "Hammer of Fate",
                Price = 250,
                Description = "This is an awesome hammer."
            };

            Loot loot2 = new Loot
            {
                Name = "Hammer of Fate",
                Price = 250,
                Description = "This is an awesome hammer."
            };

            Loot loot3 = new Loot
            {
                Name = "Broken Crystal Ball",
                Price = 250,
                Description = "This is not an awesome hammer."
            };

            Loot loot4 = new Loot
            {
                Name = "Hammer of Fate",
                Price = 249, //<-- difference
                Description = "This is an awesome hammer."
            };

            // And see if they are equal!
            Console.WriteLine($"loot1 == loot2 -> {loot1.Equals(loot2)}");
            Console.WriteLine($"loot1 == loot3 -> {loot1.Equals(loot3)}");
            Console.WriteLine($"loot1 == loot4 -> {loot1.Equals(loot4)}");
        }
    }
}