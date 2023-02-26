namespace _05_Algorithms
{
    //Demonstrates the use of variopus array algorithms
    internal class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //Simulation parameters
            const int ARRAY_SIZE = 20;
            const int MIN_RANDOM_VALUE = 1;
            const int MAX_RANDOM_VALUE = 11;

            //Create an integer array with random values
            int[] vals = ArrayUtils.GetRandomArray(ARRAY_SIZE, MIN_RANDOM_VALUE, MAX_RANDOM_VALUE);

            //Print the array
            ArrayUtils.PrintArray(vals);

            //Let's try to find a random int
            int searchInput = new Random().Next(MIN_RANDOM_VALUE, MAX_RANDOM_VALUE);

            Console.WriteLine($"Searching for {searchInput}");

            //Find the index of the specifed value
            int index = ArrayUtils.LinearSearch(vals, searchInput);

            //If it isn't found the method returns a -1
            if(index == -1) 
            {
                Console.WriteLine("Value not found");
                Console.WriteLine("Rest assured, it is not in the array, linear search checks all values");
            }
            else
            {
                Console.WriteLine("Value found at index " + index);
            }

            //Let's try to find a random int using binary search
            searchInput = new Random().Next(MIN_RANDOM_VALUE, MAX_RANDOM_VALUE);

            Console.WriteLine($"Searching for {searchInput}");

            index = ArrayUtils.BinarySearch(vals, searchInput);

            //If it isn't found the method returns a -1
            if (index == -1)
            {
                Console.WriteLine("Value not found");
                Console.WriteLine("Did you remember to sort your array before using a binary search?");
            }
            else
            {
                Console.WriteLine("Value found at index " + index);
                Console.WriteLine("If you didn't sort before using binary search, you got lucky.");
            }

            Console.WriteLine("Sorting the array");
            ArrayUtils.BubbleSort(vals);
            ArrayUtils.PrintArray(vals);

            Console.WriteLine("Randomizing");
            ArrayUtils.RandomizeArray(vals, 100);
            ArrayUtils.PrintArray(vals);

            Console.WriteLine("Sorting the array again");
            ArrayUtils.OptimizedBubbleSort(vals);
            ArrayUtils.PrintArray(vals);
        }
    }
}