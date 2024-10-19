using LabUtils;

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
            Dice d6 = new Dice();

            //create a Dice object using the parameterized class constructor
            Dice d4 = new Dice(4);

            //create a Dice object using implicit default constructor
            Dice anotherD6 = new();
            Dice d8 = new(5);

            //create using a implicit variable type
            var yetAnotherD6 = new Dice();
            var d10 = new Dice(10);

            Console.WriteLine($"{d6} = {d6.NextRoll()}");
            Console.WriteLine($"{d4} = {d4.NextRoll()}");
            Console.WriteLine($"{anotherD6} = {anotherD6.NextRoll()}");
            Console.WriteLine($"{d8} = {d8.NextRoll()}");
            Console.WriteLine($"{yetAnotherD6} = {yetAnotherD6.NextRoll()}");
            Console.WriteLine($"{d10} = {d10.NextRoll()}");

            //lets now modify the d10 reference to have a NumSides of 100
            d10.NumSides = 100;

            for ( int i = 0; i < 10; i++ ) 
            {
                Console.WriteLine($"{d10} = {d10.NextRoll()}");
            }
        }
    }
}
