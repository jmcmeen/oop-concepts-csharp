namespace _04_5_Exceptions
{
    /// <summary>
    /// Demonstrates the use of an Exception
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            int value = 0;

            //try to execute some code that might throw an Exception
            try
            {
                //Create a loop that eventually divides by 0
                for (int i = 25; i >= 0; i--)
                {
                    Console.Write($"7/{i} = ");
                    value = 25 / i;
                    Console.WriteLine($"{value}");
                }
            }
            catch (DivideByZeroException ex)
            {
                //Print the Exception's message
                Console.WriteLine(ex.Message);

                //We could also print the StackTrace if we were debugging and needed more information
                //Console.WriteLine(ex.StackTrace);
            }
        }
    }
}