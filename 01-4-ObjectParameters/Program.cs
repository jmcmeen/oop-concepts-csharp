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
            Dice dice = new Dice();
            Roll5Times(dice);
            RollNumTimes(dice, 10);
        }

        /// <summary>
        /// Rolls a dice 5 times
        /// </summary>
        /// <param name="dice"></param>
        static void Roll5Times(Dice dice)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(dice.NextRoll());
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
                Console.WriteLine(dice.NextRoll());
            }
            Console.WriteLine();
        }
    }
}
