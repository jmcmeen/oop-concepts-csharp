namespace _12_1_Delegates
{
    internal static class Program
    {
        static void Main()
        {
            string s = "I love deadlines. I love the whooshing noise they make as they go by.";

            ConsoleLogger c = new ConsoleLogger();

            c.Print(s);

            c.Print = c.PrintUpper;

            c.Print(s);

            c.Print = c.PrintLower;

            c.Print(s);

            c.Print = c.PrintAlternatingCase;

            c.Print(s);

            c.Print(DoMath(2, 2, MathDelegates.Add).ToString());
            c.Print(DoMath(2, 2, MathDelegates.Subtract).ToString());
            c.Print(DoMath(2, 2, MathDelegates.Multiply).ToString());
            c.Print(DoMath(2, 2, MathDelegates.Divide).ToString());

        }

        public static int DoMath(int x, int y, MathDelegates.Math doMath)
        {
            return doMath(x, y);
        }
    }
}
