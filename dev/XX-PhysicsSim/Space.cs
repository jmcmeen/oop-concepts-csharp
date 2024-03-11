namespace XX_Physics
{
    internal class Space
    {
        public List<Particle> particles;

        public Space()
        {
            particles = new List<Particle>();
        }

        public void AddParticle(double x, double y, double z, double mass)
        {
            particles.Add(new Particle(x, y, z, mass));
        }


    }
}
