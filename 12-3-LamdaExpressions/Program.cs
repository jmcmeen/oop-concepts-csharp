namespace _12_3_LamdaExpressions
{
    internal static class Program
    {
        static void Main()
        {
            Console.WriteLine(Add(2, 2));
            Console.WriteLine(Multiply(3,3));
        }

        static int Add (int x, int y) => x + y;

        static int Multiply (int x, int y) => x * y;
    }
}
