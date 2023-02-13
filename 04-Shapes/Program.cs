namespace _04_Shapes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(1);
            Rectangle r = new Rectangle(2, 3);

            List<Shape> shapes = new List<Shape>(); 

            shapes.Add(c);
            shapes.Add(r);

            foreach (Shape s in shapes)
            {
                Console.WriteLine(s);
            }

            foreach(Shape s in shapes)
            {
                Console.WriteLine(s.GetType());
            }

            foreach (Shape s in shapes)
            {
                Console.WriteLine(s.CalculateArea());
            }
        }
    }
}