namespace XX_Physics
{
    internal class Particle
    {
        public double mass;  //kg
        public Vector v;

        public Particle(double x, double y, double z, double mass)
        {
            this.mass = mass;

            v = new Vector(x, y, x);
        }

        public double CalculateForce(Particle p)
        {
            return Constants.GRAV * (mass * p.mass / Math.Pow(v.CalculateDistance(p.v), 2));
        }

        public override string ToString()
        {
            return $"{{{mass}, {v.x},{v.y},{v.z}}}";
        }
    }
}
