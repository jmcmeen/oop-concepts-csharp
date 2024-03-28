namespace _05_Algorithms
{
    /// <summary>
    /// Misc integer array algorithms
    /// </summary>
    internal static class ArrayUtils
    {
        /// <summary>
        /// Sort array with basic bubble sort algorithm
        /// </summary>
        /// <param name="inputArray"></param>
        public static void BubbleSort(int[] inputArray)
        {
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 1; j < inputArray.Length; j++)
                {
                    if (inputArray[j] < inputArray[j - 1])
                    {
                        Swap(inputArray, j, j - 1);
                    }
                }
            }
        }

        /// <summary>
        /// Sort array with optimized bubble sort algorithm
        /// </summary>
        /// <param name="inputArray">The array to be sorted</param>
        public static void OptimizedBubbleSort(int[] inputArray)
        {
            bool isSorted;
            for (int i = 0; i < inputArray.Length; i++)
            {
                isSorted = true;
                for (int j = 1; j < inputArray.Length - i; j++)
                {
                    if (inputArray[j] < inputArray[j - 1])
                    {
                        Swap(inputArray, j, j - 1);
                        isSorted = false;
                    }
                }
                if (isSorted)
                {
                    break;
                }
            }
        }

        /// <summary>
        /// Swaps two values in an array at the specified indicies
        /// </summary>
        /// <param name="inputArray">The source array</param>
        /// <param name="index1">The first index</param>
        /// <param name="index2">The second index</param>
        public static void Swap(int[] inputArray, int index1, int index2)
        {
            int temp = inputArray[index1];
            inputArray[index1] = inputArray[index2];
            inputArray[index2] = temp;
        }

        /// <summary>
        /// Searches an array for a specified value using linear search algorithm
        /// </summary>
        /// <param name="inputArray">The array to be searched</param>
        /// <param name="searchTerm">The value to search for</param>
        /// <returns>The index of the location of the searchTerm, -1 if not found</returns>
        public static int LinearSearch(int[] inputArray, int searchTerm)
        {
            int foundIndex = -1;
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] == searchTerm)
                {
                    foundIndex = i;
                    break;
                }
            }
            return foundIndex;
        }

        /// <summary>
        /// Searches a sorted array for a specified value using linear search algorithm
        /// </summary>
        /// <param name="inputArray">The sorted array to be searched</param>
        /// <param name="searchTerm">The value to search for</param>
        /// <returns>The index of the location of the searchTerm, -1 if not found</returns>
        public static int BinarySearch(int[] inputArray, int searchTerm)
        {
            int low = 0;
            int high = inputArray.Length - 1;
            int mid;

            while (high >= low)
            {
                mid = (low + high) / 2;

                if (inputArray[mid] == searchTerm)
                {
                    return mid;
                }
                else if (searchTerm < inputArray[mid])
                {
                    high = mid - 1;
                }
                else if (searchTerm > inputArray[mid])
                {
                    low = mid + 1;
                }
            }

            return -1;
        }

        /// <summary>
        /// Randomizes an input array
        /// </summary>
        /// <param name="inputArray">The array to be randomized</param>
        /// <param name="numSwaps">The number of swaps to perform</param>
        public static void RandomizeArray(int[] inputArray, int numSwaps)
        {
            for (int i = 0; i < numSwaps; i++)
            {
                Swap(inputArray, GetRandomIndex(inputArray), GetRandomIndex(inputArray));
            }
        }

        /// <summary>
        /// Return a random index from an array
        /// </summary>
        /// <param name="inputArray"></param>
        /// <returns></returns>
        public static int GetRandomIndex(int[] inputArray)
        {
            return new Random().Next(inputArray.Length);
        }

        /// <summary>
        /// Returns a randomly generated array of values
        /// </summary>
        /// <param name="size">Number of array values</param>
        /// <param name="minVal">Min random value</param>
        /// <param name="maxVal">Max random value</param>
        /// <returns></returns>
        public static int[] GetRandomArray(int size, int minVal, int maxVal)
        {
            int[] randomArray = new int[size];

            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = new Random().Next(minVal, maxVal);
            }

            return randomArray;
        }

        /// <summary>
        /// Prints an array
        /// </summary>
        /// <param name="inputArray">The array to print</param>
        public static void PrintArray(int[] inputArray)
        {
            foreach (int i in inputArray)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine();
        }
    }
}
