namespace XX_Test
{
    /// <summary>
    /// Models a multisided die
    /// </summary>
    internal class Dice
    {
        private int numSides;

        /// <summary>
        /// Paramterized constructor
        /// </summary>
        /// <param name="numSides">Number of sides on the die</param>
        public Dice(int numSides)
        {
            this.numSides = numSides;
        }

        /// <summary>
        /// Rolls a die
        /// </summary>
        /// <returns> Returns a number between 1 and numSides(inclusive)</returns>
        public long Roll()
        {
            return new Random().NextInt64(1, numSides + 1);
        }

        /// <summary>
        /// Converts to a string
        /// </summary>
        /// <returns>The die converted to a string</returns>
        public override string ToString()
        {
            return $"d{numSides}";
        }
    }
}
