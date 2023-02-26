namespace _04_Shapes
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius) {
            Radius = radius;
        }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString()
        {
            return $"The area of this circle is {CalculateArea()}";
        }
    }
}
