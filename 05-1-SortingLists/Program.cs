namespace _05_SortingLists
{
    /// <summary>
    /// Demonstrates sorting lists of built in types
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            List<int> integer = new List<int>();
            Random random = new Random();

            const int NUM_INTS = 25;
            const int MAX_INT = 10;

            //Fill the list with random values
            for (int i = 0; i < NUM_INTS; i++)
            {
                integer.Add(random.Next(MAX_INT));
            }

            //Print the list
            Console.WriteLine("\nUnsorted List");
            foreach (int i in integer)
            {
                Console.WriteLine(i);
            }

            //Sort the list
            integer.Sort();

            //Print the list
            Console.WriteLine("\nSorted List");
            foreach (int i in integer)
            {
                Console.WriteLine(i);
            }
        }
    }
}