namespace _02_6_StaticHelpers
{
    /// <summary>
    /// Models a Volt in electricity    
    /// </summary>
    internal class Volt
    {
        private double amps, ohms;

        public Volt(double amps, double ohms)
        {
            this.amps = amps;
            this.ohms = ohms;
        }

        /// <summary>
        /// Calculates and returns the Volts
        /// </summary>
        /// <returns></returns>
        public double GetValue()
        {
            return amps * ohms;
        }
    }
}
