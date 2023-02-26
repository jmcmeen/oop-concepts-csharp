namespace XX_ObjectsVSStaticMethods
{
    /// <summary>
    /// 
    /// </summary>
    internal class Volt
    {
        private double amps, ohms;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="amps"></param>
        /// <param name="ohms"></param>
        public Volt(double amps, double ohms)
        {
            this.amps = amps;
            this.ohms = ohms;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public double GetValue()
        {
            return amps * ohms;
        }
    }
}
