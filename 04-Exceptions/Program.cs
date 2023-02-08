namespace _04_Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value = 0;

            try
            {
                for (int i = 5; i >= 0; i--)
                {
                    value = 7 / i;
                }

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Console.WriteLine(value);
        }
    }
}