namespace XX_SplitStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aSentence = "Hello World! How are you today!";

            string[] aSplitSentence = aSentence.Split(" ");

            foreach (string s in aSplitSentence)
            {
                Console.WriteLine(s);
            }
        }
    }
}