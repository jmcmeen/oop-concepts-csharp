namespace XX_Physics
{
    internal class Particle
    {
        public double mass;  //kg
        public Point3d p;

        public Particle(double x, double y, double z, double mass)
        {
            this.mass = mass;

            p = new Point3d(x, y, x);
        }

        public double CalculateForceMagnitude(Particle particle)
        {
            return Constants.GRAV * (mass * particle.mass / Math.Pow(p.CalculateDistance(particle.p), 2));
        }

        public override string ToString()
        {
            return $"{{{mass}, {p.x},{p.y},{p.z}}}";
        }
    }
}
