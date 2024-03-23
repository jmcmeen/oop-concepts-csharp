namespace XX_Physics
{
    internal class Point3d : Vector3d
    {
        public Point3d(double x, double y, double z) : base(x, y, z)
        {
        }

        public double CalculateDistance(Vector3d v)
        {
            return Math.Sqrt(Math.Pow(v.x - x, 2) + Math.Pow(v.y - y, 2) + Math.Pow(v.z - z, 2));
        }
    }
}
