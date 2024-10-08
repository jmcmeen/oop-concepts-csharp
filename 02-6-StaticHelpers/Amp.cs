﻿namespace _02_6_StaticHelpers
{
    /// <summary>
    /// Models an Amp (current) in electricity
    /// </summary>
    internal class Amp
    {
        //private fields
        private double _ohms, _volts;

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="ohms">resistance in Ohms</param>
        /// <param name="volts">volts</param>
        public Amp(double ohms, double volts)
        {
            _ohms = ohms;
            _volts = volts;
        }

        /// <summary>
        /// Calculates and returns the current in Amps
        /// </summary>
        /// <returns></returns>
        public double GetValue()
        {
            return _volts / _ohms;
        }
    }
}
