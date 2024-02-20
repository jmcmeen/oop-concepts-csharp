namespace CircleCalculator
{
    /// <summary>
    /// Helps with Circle Math
    /// </summary>
    internal static class CircleHelper
    {
        /// <summary>
        /// Calculates circle area
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public static float CalculateCircleArea(float radius)
        {
            return (float)(Math.PI * Math.Pow(radius, 2));
        }

        /// <summary>
        /// Calculate circle
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        public static float CalculateCircleRadius(float area)
        {
            return (float)Math.Sqrt(area / Math.PI);
        }
    }
}
