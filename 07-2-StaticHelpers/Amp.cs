namespace _07_02_StaticHelpers
{
    internal class Amp
    {
        public double ohms, volts;

        public Amp(double ohms, double volts)
        {
            this.ohms = ohms;
            this.volts = volts;
        }

        public double GetValue()
        {
            return volts / ohms;
        }
    }
}
