using SampleClasses;

namespace _02_5_ToString
{
    /// <summary>
    /// A program demonstrating ToString
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            /* Investigating the Circle class, we see it has a ToString method.
             * The ToString method returns a string representation of the object.
             * All objects in C# have a ToString method by default, so we add the
             * override keyword to the ToString method definition. This will
             * be discussed in a later section on overriding and inheritance. */


            Circle circle = new Circle()
            {
                Radius = 5
            };

            /* Console.WriteLine has a method overload that will accept an object of 
             * any type. It will call the ToString method on that object and then print it.*/
            Console.WriteLine(circle);

            // In some cases you will see it explicitly called.
            Console.WriteLine(circle.ToString());
        }
    }
}
