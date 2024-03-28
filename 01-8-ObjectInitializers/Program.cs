using SampleClasses; // Loot is in the SampleClasses class library in this solution

namespace _01_8_ObjectInitializers
{
    /// <summary>
    /// Program demonstrating object-initializers
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            // Declare a Loot by using the constructor that has two parameters.
            Loot loot1 = new Loot("Sword", 20, "This is not an awesome hammer.");

            // Make the same declaration by using an object initializer and sending
            // arguments for the first and last names. The parameterless constructor is
            // invoked in processing this declaration, not the constructor that has
            // two parameters.
            Loot loot2 = new Loot()
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
            Loot loot4 = new Loot()
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