namespace _07_DiceRoller
{
    internal class Dice
    {
        private int numSides;

        public Dice(int numSides)
        {
            this.numSides = numSides;
        }

        public long Roll()
        {
            return new Random().NextInt64(1, numSides + 1);
        }

        public override string ToString()
        {
            return $"d{numSides}";
        }

    }
}
