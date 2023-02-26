namespace _07_DiceRoller
{
    /// <summary>
    /// 
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine($"d6 = {DiceRoller.Roll(6)}");
            Console.WriteLine($"d20 = {DiceRoller.Roll(20)}");
            Console.WriteLine($"d100 = {DiceRoller.Roll(100)}");
        }
    }
}