namespace _07_02_StaticHelpers
{
    internal class Volt
    {
        private double amps, ohms;

        public Volt(double amps, double ohms)
        {
            this.amps = amps;
            this.ohms = ohms;
        }

        public double GetValue()
        {
            return amps * ohms;
        }
    }
}
