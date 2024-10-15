namespace _01_9_ObjectsInTheWild
{
    internal static class Program
    {
        static void Main()
        {
            Triangle1 triangle1 = new Triangle1();
            triangle1.sideA = 1;
            triangle1.sideB = 2;
            triangle1.sideC = 3;

            Console.WriteLine($"triangle1 sideA = {triangle1.sideA}");
            Console.WriteLine($"triangle1 sideB = {triangle1.sideB}");
            Console.WriteLine($"triangle1 sideC = {triangle1.sideC}");
            Console.WriteLine($"triangle1 area = {triangle1.CalculateArea()}");

            Triangle2 triangle2 = new Triangle2();
            triangle2.SetSideA(1);
            triangle2.SetSideB(2);
            triangle2.SetSideC(3);

            Console.WriteLine($"triangle2 sideA = {triangle2.GetSideA()}");
            Console.WriteLine($"triangle2 sideB = {triangle2.GetSideB()}");
            Console.WriteLine($"triangle2 sideC = {triangle2.GetSideC()}");
            Console.WriteLine($"triangle2 area = {triangle2.CalculateArea()}");

            Triangle3 triangle3 = new Triangle3();
            triangle3.SideA = 1;
            triangle3.SideB = 2;
            triangle3.SideC = 3;

            Console.WriteLine($"triangle3 sideA = {triangle3.SideA}");
            Console.WriteLine($"triangle3 sideB = {triangle3.SideB}");
            Console.WriteLine($"triangle3 sideC = {triangle3.SideC}");
            Console.WriteLine($"triangle3 area = {triangle3.CalculateArea()}");

            Triangle4 triangle4 = new Triangle4();
            triangle4.SideA = 1;
            triangle4.SideB = 2;
            triangle4.SideC = 3;

            Console.WriteLine($"triangle3 sideA = {triangle4.SideA}");
            Console.WriteLine($"triangle3 sideB = {triangle4.SideB}");
            Console.WriteLine($"triangle3 sideC = {triangle4.SideC}");
            Console.WriteLine($"triangle3 area = {triangle4.Area}");
        }
    }
}