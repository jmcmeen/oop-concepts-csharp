namespace _04_3_Shapes
{
    /// <summary>
    /// Demonstrates the use of Abstract classes
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //Declare some Shape references and new up memory
            Circle c = new Circle(1);
            Rectangle r = new Rectangle(2, 3);

            //Create a list of type Shape, Circle and Rectangles base (parent) class
            List<Shape> shapes = new List<Shape>(); 
            shapes.Add(c);
            shapes.Add(r);

            //Polymorphic behavior using Shape reference
            foreach (Shape s in shapes)
            {
                Console.WriteLine(s);
                Console.WriteLine(s.CalculateArea());
                Console.WriteLine(s.GetType() + "\n");
            }
        }
    }
}