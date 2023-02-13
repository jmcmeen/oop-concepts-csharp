namespace _04_Shapes
{
    internal class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
        }

        public override double CalculateArea()
        {
            return Length * Width;
        }

        public override string ToString()
        {
            return $"The area of this rectangle is {CalculateArea()}";
        }
    }
}
