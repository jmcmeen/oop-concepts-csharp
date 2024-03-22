using _09_1_Equals;

namespace _09_2_HashCode
{
    internal static class Program
    {
        static void Main()
        {
            Loot loot1 = new Loot
            {
                name = "Hammer of Fate",
                cost = 250.00
            };

            Loot loot2 = new Loot
            {
                name = "Hammer of Fate",
                cost = 250.00
            };

            Loot loot3 = new Loot
            {
                name = "Broken Crystal Ball",
                cost = 250.00
            };

            Console.WriteLine($"loot1 HashCode = {loot1.GetHashCode()}");
            Console.WriteLine($"loot2 HashCode = {loot2.GetHashCode()}");
            Console.WriteLine($"loot3 HashCode = {loot3.GetHashCode()}");

        }
    }
}