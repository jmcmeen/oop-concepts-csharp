using SampleClasses;

namespace _01_9_ObjectLists
{
    /// <summary>
    /// Demonstrates object lists
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            // Create a list of Circles
            List<Circle> circles = new List<Circle>();

            // Add some circles
            circles.Add(new Circle() { Radius = 1 });
            circles.Add(new Circle() { Radius = 2 });
            circles.Add(new Circle() { Radius = 4 });

            // Display the area of each circle using a for loop
            for (int i = 0; i < circles.Count; i++)
            {
                Console.WriteLine($"{circles[i].Area}");
            }

            Console.WriteLine();

            // Display the area of each circle using a foreach loop
            foreach (var circle in circles)
            {
                Console.WriteLine($"{circle.Area}");
            }

            Console.WriteLine();

            // If you want to change the value of a Circle, you must use the for loop
            // because foreach loops are read only
            for (int i = 0; i < circles.Count; i++)
            {
                circles[i].Radius = circles[i].Radius * 2;
            }

            // If you only need to access each element in the list, you can use a foreach loop
            foreach (var circle in circles)
            {
                Console.WriteLine($"{circle.Area}");
            }
        }
    }
}
