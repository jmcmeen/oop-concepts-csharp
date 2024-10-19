using LabUtils;

namespace _02_3_ObjectArrays
{
    /// <summary>
    /// Demonstrates the use of object arrays
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //  create an array of Circle objects
            Circle[] circles = new Circle[3];

            // here we can manually add some Circle objects to the array
            circles[0] = new Circle()
            {
                Radius = 1
            };
            circles[1] = new Circle()
            {
                Radius = 2
            };
            circles[2] = new Circle()
            {
                Radius = 3
            };

            // We can manually print each one too
            Console.WriteLine("circles[0].Area = {0}", circles[0].Area);
            Console.WriteLine("circles[1].Area = {0}", circles[1].Area);
            Console.WriteLine("circles[2].Area = {0}", circles[2].Area);

            // print a blank line
            Console.WriteLine();

            //Or we could use some loops! Let's make circles a bigger array
            circles = new Circle[20];

            // fill the array with Circle objects and set to random radius
            for (int i = 0; i < circles.Length; i++)
            {
                circles[i] = new Circle()
                {
                    Radius = new Random().Next(1, 10)
                };
            }

            //loop through the array and print each Circle
            for (int i = 0; i < circles.Length; i++)
            {
                Console.WriteLine("circles[{0}].Area = {1}", i, circles[i].Area);
            }

        }
    }
}
