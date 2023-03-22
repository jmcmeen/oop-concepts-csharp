namespace _09_1_Equals
{
    internal class Program
    {
        static void Main()
        {
            string s = "Hello";
            string t = "Hello";

            if (s.Equals(t))
            {
                Console.WriteLine("s and t are equal");
            }
            else
            {
                Console.WriteLine("s and t are not equal");
            }


            Loot loot1 = new Loot
            {
                name = "Hammer of Fate",
                cost = 250.00
            };

            Loot loot2 = new Loot
            {
                name = "Hammer of Fate",
                cost = 25.00
            };

            Console.WriteLine(loot1.GetHashCode());
            Console.WriteLine(loot2.GetHashCode());
        }

    }
}