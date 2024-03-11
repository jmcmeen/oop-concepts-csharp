using System.Diagnostics;
using System.Text;

namespace _06_4_StringBuilder
{
    /// <summary>
    /// Demonstrates run times of String concatenation vs. StringBuilder
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            Stopwatch watch = new Stopwatch();

            for (int i = 2; i < 10000000; i*=2)
            {
                Console.Write($"{i} iterations using String concatenation - ");
                watch.Start();
                UsingConcatentation(i);
                watch.Stop();

                Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");

                watch.Reset();

                Console.Write($"{i} iterations using StringBuilder - ");
                watch.Start();
                UsingStringBuilder(i);
                watch.Stop();

                Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms\n");

                watch.Reset();
            }
        }

        /// <summary>
        /// Build a really large string using concatenation
        /// </summary>
        /// <param name="iterations"></param>
        static void UsingConcatentation(int iterations)
        {
            string s = "Z";
            for (int i = 0; i < iterations; i++)
            {
                s += "Z";
            }
        }

        /// <summary>
        /// Build a really large string using StringBuilder
        /// </summary>
        /// <param name="iterations"></param>
        static void UsingStringBuilder(int iterations)
        {
            string s = "Z";
            StringBuilder sb = new StringBuilder(s);

            for (int i = 0; i < iterations; i++)
            {
                sb.Append("Z");
            }
        }
    }
}