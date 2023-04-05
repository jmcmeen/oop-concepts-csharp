namespace _02_2_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SplitStrings();
            StringContains();
        }

        public static void SplitStrings()
        {
            string aSentence = "Hello World! How are you today!";

            string[] aSplitSentence = aSentence.Split(" ");

            foreach (string s in aSplitSentence)
            {
                Console.WriteLine(s);
            }
        }

        public static void StringContains()
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
            foreach (char c in test.ToLower())
            {
                if (!validChars.ToLower().Contains(c))
                {
                    isValid = false;
                    break;
                }
            }

            Console.WriteLine($"{test} isValid = {isValid} ");
        }
    }
}