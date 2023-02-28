namespace _07_02_StaticHelpers
{
    /// <summary>
    /// 
    /// </summary>
    internal static class OhmsLawUtility
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ohms"></param>
        /// <param name="volts"></param>
        /// <returns></returns>
        public static double GetAmps(double ohms, double volts)
        {
            return volts / ohms;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="amps"></param>
        /// <param name="ohms"></param>
        /// <returns></returns>
        public static double GetVolts(double amps, double ohms)
        {
            return amps * ohms;
        }

        /// <summary>
        /// 
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
