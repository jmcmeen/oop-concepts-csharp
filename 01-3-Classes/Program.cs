using SampleClasses; // Dice is in the SampleClasses class library in this solution

namespace _01_3_Classes
{
    //Demonstrates the use of a Dice object
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //create a Dice object using the default class constructor
            Dice dice1 = new Dice();

            //simplified with explicit reference on left
            Dice dice2 = new(); 

            Console.WriteLine($"dice1 roll = {dice1.NextRoll()}");
            Console.WriteLine($"dice2 roll = {dice2.NextRoll()}");
        }
    }
}
