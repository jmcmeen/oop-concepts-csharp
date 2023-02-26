namespace _07_02_StaticHelpers
{
    internal class Ohm
    {
        private double amps, volts;

        public Ohm(double amps, double volts)
        {
            this.amps = amps;
            this.volts = volts;
        }

        public double GetValue()
        {
            return volts / amps;
        }
    }
}
