namespace _05_SortingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();
            Random random = new Random();

            const int NUM_INTS = 25;
            const int MAX_INT = 10;

            //Fill the list with random values
            for (int i = 0; i < NUM_INTS; i++)
            {
                ints.Add(random.Next(MAX_INT));
            }

            //Print the list
            Console.WriteLine("\nUnsorted List");
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }

            //Sort the list
            ints.Sort();

            //Print the list
            Console.WriteLine("\nSorted List");
            foreach (int i in ints)
            {
                Console.WriteLine(i);
            }
        }
    }
}