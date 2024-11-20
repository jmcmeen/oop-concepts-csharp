namespace _06_1_GenericMethods
{
    /// <summary>
    /// A few handy Generic methods
    /// </summary>
    internal static class Generics
    {
        private static readonly Random r = new Random();

        /// <summary>
        /// Performs a swap on an array of any type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="inputArray"></param>
        /// <param name="index1"></param>
        /// <param name="index2"></param>
        public static void Swap<T>(T[] inputArray, int index1, int index2)
        {
            T temp;
            temp = inputArray[index1];
            inputArray[index1] = inputArray[index2];
            inputArray[index2] = temp;
        }

        /// <summary>
        /// Prints an array of any type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="inputArray"></param>
        public static void PrintArray<T>(T[] inputArray)
        {
            foreach (T item in inputArray)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Returns a random Enum value from any Enum type
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>T</returns>
        public static T RandomEnumValue<T>()
        {
            var v = Enum.GetValues(typeof(T));
            return (T)v.GetValue(r.Next(v.Length))!;
        }
    }
}
