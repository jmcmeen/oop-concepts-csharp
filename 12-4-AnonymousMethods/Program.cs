using System.Runtime.InteropServices;

namespace _12_4_AnonymousMethods
{
    internal class Program
    {
        public delegate void Print(int value);

        static void Main()
        {
            //Create an anonymous method, a delegate with no name
            Print print = delegate (int val) {
                Console.WriteLine($"Inside Anonymous method. Value: {val}");
            };

            print(100);

            //Create another anonymous method and assign to print
            print = delegate (int val)
            {
                Console.WriteLine($"shh secret method - {val}");
            };

            print(200);

            //Anonymous methods can be passed as parameters to methods that accept delegates
            Do(8, delegate (int val) { Console.WriteLine(val + " passing the anonymous method into another method"); }) ;

            //We can also use lambda expressions which is more common
            Do(10, (int val) => Console.WriteLine($"{val} super secret") );
        }

        public static void Do(int val, Print p)
        {
            p(val);
        }
    }
}
