namespace _07_DiceRoller
{
    /// <summary>
    /// Static helper class 
    /// </summary>
    internal class DiceRoller
    {
        /// <summary>
        /// Creates a Dice object, rolls it, and returns value
        /// </summary>
        /// <param name="numSides">Number of sides on the die</param>
        /// <returns></returns>
        public static long Roll(int numSides)
        {
            return new Dice(numSides).Roll();
        }

        /// <summary>
        /// Creates a Dice object, rolls it numDice times, totals all the rolls, and returns the total
        /// </summary>
        /// <param name="numDice">The number of dice to roll</param>
        /// <param name="numSides">The number of sides on each die</param>
        /// <returns>The total of all dice rolls</returns>
        public static long RollMultiple(int numDice, int numSides)
        {
            Dice d = new Dice(numSides);  //create Dice object
            long total = 0; //accumulator

            //For numDice times
            for (int i = 0; i < numDice; i++)
            {
                //Roll 
                total += d.Roll();
            }

            return total;
        }
    }
}
