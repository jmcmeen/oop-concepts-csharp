namespace _04_7_DiceRoller
{
    /// <summary>
    /// Roll the dice! Uses a static helper class
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //For every side in the array
            foreach (var numSide in new[] {6, 20, 100})
            {
                //Roll a die with the number sides
                Console.WriteLine($"d{numSide} = {DiceRoller.Roll(numSide)}");

                //For each numDice in the array
                foreach (var numDice in new[] {2,3,4,5})
                {
                    //Roll a numSide die numSide times
                    Console.WriteLine($"{numDice}d{numSide} = {DiceRoller.RollMultiple(numDice, numSide)}");
                }

                //Create a separator between blocks
                Console.WriteLine();
            }
        }
    }
}