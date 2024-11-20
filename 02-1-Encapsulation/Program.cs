using LabUtils;

namespace _02_1_Encapsulation
{
    /// <summary>
    /// A program demonstrating encapsulation
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            /* Encapsulation refers to the bundling of data(attributes) 
             * and methods(functions) that operate on that data within a 
             * single unit, called a class, or instances of classes, objects.
             */

            /* Dice is a logical unit of code that Encapsulates both the data 
             * methods needed to return random dice rolls*/
            Dice dice = new Dice(numSides: 20);

            Console.WriteLine(dice.NextRoll());
        }
    }
}
