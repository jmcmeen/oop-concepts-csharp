using SampleClasses;

namespace _01_4_ObjectParameters
{
    /// <summary>
    /// Program demonstrating passing objects as parameters
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //Create a d6
            Dice myDice = new Dice();

            // use a really poorly designed method to roll the Dice object 5 times
            Roll5Times(myDice);

            // use a more properly designed method to roll the Dice object 10 times
            RollNumTimes(myDice, 10);

            // use the NextRolls method in the class
            int[]? rolls = myDice.NextRolls(10);

            if(rolls != null)
            {
                for(int i = 0; i < rolls.Length; i++)
                {
                    Console.WriteLine($"{myDice} = {rolls[i]}");
                }
            }
        }

        /// <summary>
        /// Rolls a dice 5 times
        /// </summary>
        /// <param name="dice"></param>
        static void Roll5Times(Dice dice)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"{dice} = {dice.NextRoll()}");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Rolls a dice numTimes times
        /// </summary>
        /// <param name="dice"></param>
        /// <param name="numTimes"></param>
        static void RollNumTimes(Dice dice, int numTimes)
        {
            for (int i = 0; i < numTimes; i++)
            {
                Console.WriteLine($"{dice} = {dice.NextRoll()}");
            }
            Console.WriteLine();
        }
    }
}
