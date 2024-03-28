namespace _02_6_StaticHelpers
{
    /// <summary>
    /// Models an Ohm (resistance) in electricity    
    /// </summary>
    internal class Ohm
    {
        //private fields
        private double _amps, _volts;

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="amps"></param>
        /// <param name="volts"></param>
        public Ohm(double amps, double volts)
        {
            _amps = amps;
            _volts = volts;
        }

        /// <summary>
        /// Calculates and returns the resistance in Amps
        /// </summary>
        /// <returns></returns>
        public double GetValue()
        {
            return _volts / _amps;
        }
    }
}
