namespace _04_3_Shapes
{
    /// <summary>
    /// Models a Rectangle derived from Shape
    /// </summary>
    internal class Rectangle : Shape
    {
        //public auto-implemented properties
        public double Length { get; set; }
        public double Width { get; set; }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="width"> Rectangle width</param>
        /// <param name="length">Rectangle length</param>
        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
        }

        /// <summary>
        /// Calculates Rectangle's area
        /// </summary>
        /// <returns>The rectangle's area as a double</returns>
        public override double CalculateArea()
        {
            return Length * Width;
        }


        /// <summary>
        /// Converts Rectangle to a string
        /// </summary>
        /// <returns>A rectangles string representation</returns>
        public override string ToString()
        {
            return $"The area of this rectangle is {CalculateArea()}";
        }
    }
}
