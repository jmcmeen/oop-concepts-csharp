namespace _04_Shapes
{
    /// <summary>
    /// Rectangle class inherits from Shape
    /// </summary>
    internal class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="width"></param>
        /// <param name="length"></param>
        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
        }

        /// <summary>
        /// Calculates area
        /// </summary>
        /// <returns>The rectangle's area</returns>
        public override double CalculateArea()
        {
            return Length * Width;
        }


        /// <summary>
        /// Converts to a string
        /// </summary>
        /// <returns>A rectangles string representation</returns>
        public override string ToString()
        {
            return $"The area of this rectangle is {CalculateArea()}";
        }
    }
}
