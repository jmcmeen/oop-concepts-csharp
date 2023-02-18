namespace XX_ObjectsVSStaticMethods
{
    internal class OhmsLawUtility
    {
        public static double GetAmps(double ohms, double volts)
        {
            return volts / ohms;
        }

        public static double GetVolts(double amps, double ohms)
        {
            return amps * ohms;
        }

        public static double GetOhms(double amps, double volts)
        {
            return volts / amps;
        }
    }
}
