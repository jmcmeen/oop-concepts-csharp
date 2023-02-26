namespace _07_DiceRoller
{
    internal class DiceRoller
    {
        public static long Roll(int numSides)
        {
            return new Dice(numSides).Roll();
        }

        public static long RollMultiple(int numDice, int numSides)
        {
            long total = 0;
            Dice d = new Dice(numSides);

            for (int i = 0; i < numDice; i++)
            {
                total += d.Roll();
            }

            return total;
        }
    }
}
