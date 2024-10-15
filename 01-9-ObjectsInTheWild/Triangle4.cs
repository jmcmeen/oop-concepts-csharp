namespace _01_9_ObjectsInTheWild
{
    internal class Triangle4
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public double Area
        {
            get
            {
                double s = (SideA + SideB + SideC) / 2; // Semi-perimeter
                return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
            }
        }

        public Triangle4()
        {
            SideA = 1;
            SideB = 1;
            SideC = 1;
        }

        public Triangle4(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
    }
}
