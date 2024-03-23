namespace _04_3_Shapes
{
    /// <summary>
    /// Models a Circle derived from Shape
    /// </summary>
    internal class Circle : Shape
    {
        //public auto-implemented properties
        public double Radius { get; set; }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="radius">the Circle's radius</param>
        public Circle(double radius)
        {
            Radius = radius;
        }

        /// <summary>
        /// Calculates Circle Area
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        /// <summary>
        /// Convert Circle to a string
        /// </summary>
        /// <returns>string representation of the Circle</returns>
        public override string ToString()
        {
            return $"The area of this circle is {CalculateArea()}";
        }
    }
}
