namespace XX_StringContains
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string test = "Hello World";
            string validChars = "helowrd ";

            if (test.Contains("H"))
            {
                Console.WriteLine("This string contains an H");
            }
            else
            {
                Console.WriteLine("This string does not contain an H");
            }


            if (!test.Contains("Z"))
            {
                Console.WriteLine("This string does not contain a Z");
            }
            else
            {
                Console.WriteLine("This string does contain a Z");
            }

            bool isValid = true;

            //simple way to test for valid chars in a string, this would be better solved with
            //regular expressions
            foreach(char c in test.ToLower())
            {
                if(!validChars.ToLower().Contains(c))
                {
                    isValid= false;
                    break;
                }
            }


            Console.WriteLine($"{test} isValid = {isValid} ");
        }
    }
}