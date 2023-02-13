namespace _05_SortingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();
            Random random = new Random();

            //Fill the list with random values
            for (int i = 0; i < 10; i++)
            {
                ints.Add(random.Next(10));
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