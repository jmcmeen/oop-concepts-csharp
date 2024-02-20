namespace _09_1_Equals
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

            Console.WriteLine($"loot1 == loot2 -> {loot1.Equals(loot2)}");
            Console.WriteLine($"loot1 == loot3 -> {loot1.Equals(loot3)}");
        }
    }
}