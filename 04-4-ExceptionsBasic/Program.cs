namespace _04_ExceptionsBasic
{
    /// <summary>
    /// Demonstrates the use of an Exception
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Try some code that might throw an Exception
            try
            {
                //Hi :)
                PrintANiceMessage();

                //This method throws an Exception and it is caught below
                BigMad();

                //This won't get executed
                PrintANiceMessage();
            }
            catch(Exception ex)
            {
                //Exception's have messages and stack traces
                Console.WriteLine(ex.Message);

                //Console.WriteLine(ex.StackTrace);
            }
            finally
            {
                //Always means no matter if an exception was thrown or not
                Console.WriteLine("Finally blocks always get executed");
            }
        }

        /// <summary>
        /// Just a method that throws a tantrum for no reason
        /// </summary>
        /// <exception cref="Exception"></exception>
        static void BigMad()
        {
            throw new Exception();
        }

        /// <summary>
        /// Just a nice message
        /// </summary>
        /// <exception cref="Exception"></exception>
        static void PrintANiceMessage()
        {
            Console.WriteLine("Have a good day.");
        }
    }
}