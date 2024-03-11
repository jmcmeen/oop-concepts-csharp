namespace _07_01_StaticHelpers
{
    /// <summary>
    /// Helper methods for calculating common electrical mathematics
    /// </summary>
    internal static class OhmsLawUtility
    {
        /// <summary>
        /// Calculates amps
        /// </summary>
        /// <param name="ohms"></param>
        /// <param name="volts"></param>
        /// <returns></returns>
        public static double GetAmps(double ohms, double volts)
        {
            return volts / ohms;
        }

        /// <summary>
        /// Calculates volts
        /// </summary>
        /// <param name="amps"></param>
        /// <param name="ohms"></param>
        /// <returns></returns>
        public static double GetVolts(double amps, double ohms)
        {
            return amps * ohms;
        }

        /// <summary>
        /// Calculates Ohms
        /// </summary>
        /// <param name="amps"></param>
        /// <param name="volts"></param>
        /// <returns></returns>
        public static double GetOhms(double amps, double volts)
        {
            return volts / amps;
        }
    }
}
