namespace _06_06_GenericMethods
{
    /// <summary>
    /// Demonstrates the use of generic methods
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //Suppose you wanted to creat a method to swap two values in an array.
            //Since arrays have a single type, you might find yourself
            //creating repetitive code to handle specific types:
            int[] integerArray = { 1, 2, 3};
            double[] doubleArray = { 1.0, 2.0, 3.0 };

            Console.WriteLine("Print arrays:");
            PrintIntArray(integerArray);
            PrintDoubleArray(doubleArray);

            Console.WriteLine("Swap vals:");
            SwapIntArray(integerArray, 0, 2);
            SwapDoubleArray(doubleArray, 0, 2);

            Console.WriteLine("Print arrays:");
            PrintIntArray(integerArray);
            PrintDoubleArray(doubleArray);

            //This. Is. Bad. Imagine if you had to do this for every type!
            //Generic methods solve this problem for us.
            //Examine the code in the Generics.cs file included for the
            //method calls below.

            Console.WriteLine("Swap vals using generic method:");
            Generics.Swap<int>(integerArray, 0, 2);
            Generics.Swap<double>(doubleArray, 0, 2);

            //In some cases the compiler can infer which method you want without
            //the type in bracket <int>, such as below
            Console.WriteLine("Print arrays using generic method:");
            Generics.PrintArray(integerArray);
            Generics.PrintArray(doubleArray);

            //Have an enumerated type and need a random value?
            //here is your method, it accepts any enum type
            PizzaToppings p = Generics.RandomEnumValue<PizzaToppings>();

            Console.WriteLine($"{p} is the best pizza topping.");
        }

        /// <summary>
        /// Bad
        /// </summary>
        /// <param name="inputArray"></param>
        /// <param name="index1"></param>
        /// <param name="index2"></param>
        public static void SwapIntArray(int[] inputArray, int index1, int index2)
        {
            int temp;
            temp = inputArray[index1];
            inputArray[index1] = inputArray[index2];
            inputArray[index2] = temp;
        }

        /// <summary>
        /// Bad
        /// </summary>
        /// <param name="inputArray"></param>
        /// <param name="index1"></param>
        /// <param name="index2"></param>
        public static void SwapDoubleArray(double[] inputArray, int index1, int index2)
        {
            double temp;
            temp = inputArray[index1];
            inputArray[index1] = inputArray[index2];
            inputArray[index2] = temp;
        }

        /// <summary>
        /// Bad
        /// </summary>
        /// <param name="inputArray"></param>
        public static void PrintIntArray(int[] inputArray)
        {
            foreach (double item in inputArray)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Still bad
        /// </summary>
        /// <param name="inputArray"></param>
        public static void PrintDoubleArray(double[] inputArray)
        {
            foreach (double item in inputArray)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine();
        }
    }
}