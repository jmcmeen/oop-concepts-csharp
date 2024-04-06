namespace _13_1_LINQ
{
    /// <summary>
    /// Demonstrates Language Integrated Query (LINQ)
    /// </summary>
    internal static class Program
    {
        static void Main()
        {
            //Create a list of 100 random integers from 1 to 1000000
            List<int> integerList = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                integerList.Add(new Random().Next(1000000));
            }

            //Use LINQ to get a list of values less than 500000.
            IEnumerable<int> integerQuery =
                from val in integerList
                where val < 500000
                select val;

            //This is now an iterable IEnumerable
            Console.WriteLine("Printing all values less than 500000");
            foreach(int integer in integerQuery)
            {
                Console.WriteLine(integer);
            }

            //LINQ also supports lambda expressions
            Console.WriteLine("Printing all values less than 500000");
            integerQuery = integerList.Where(x => x < 500000);
            foreach (int integer in integerQuery)
            {
                Console.WriteLine(integer);
            }
        }
    }
}
