namespace XX_Physics
{
    internal class Vector
    {
        public double x, y, z;
        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double CalculateDistance(Vector v)
        {
            return Math.Sqrt(Math.Pow(v.x - x, 2) + Math.Pow(v.y - y, 2) + Math.Pow(v.z - z, 2));
        }
    }
}
