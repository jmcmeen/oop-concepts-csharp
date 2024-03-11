using System.Diagnostics;

namespace _07_01_StaticHelpers
{
    /// <summary>
    /// Program that slowly increments ohms for a series of volt values
    /// The program also calculated how many ticks it spends in static methods
    /// versus object oriented methods
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            double ohmsCap = 10000.0;                   //ohms upper limit
            double ohmsIncrement = 0.0001;              //value to increment ohms by each cycle
            double[] volts = { 1.5, 3, 4.5, 9, 12 };    //volt values to iterate through
            double printDelay = 1000000;               //pagination variable
            Stopwatch watch = new Stopwatch();          //Stopwatch objects to measure run time
            long staticTicks = 0;                       //variable to hold accumulated ticks in static method calls
            long objectTicks = 0;                       //variable to hold accumulated ticks in object calls
            double amps;

            //For every value in volt array
            foreach(double volt in volts)
            {
                //count how many times ohms is incremented
                long count = 0;

                //for every ohmsIncrement up to ohmsCap
                for(double ohm = ohmsIncrement; ohm < ohmsCap; ohm+= ohmsIncrement)
                {
                    bool print = false;
                    
                    //only print the results every printDelay times
                    print = count % printDelay == 0;

                    //Start a timer
                    watch.Start();

                    //Calculate the amps based on the volts and ohms using static helper
                    amps = OhmsLawUtility.GetAmps(ohm, volt);

                    //Stop the timer
                    watch.Stop();

                    //Capture the elapsed ticks for static routines
                    staticTicks += watch.ElapsedTicks;

                    //Reset the time for the next test
                    watch.Reset();

                    //Print current values of volt, ohm, amps
                    if (print)
                    {
                        Console.WriteLine($"volts = {volt} ohms = {ohm} amps = {amps}");
                    }
                    
                    //Start a timer
                    watch.Start();

                    //Calculate the amps using an Amp Object
                    amps = new Amp(ohm, volt).GetValue();
                    
                    //Stop the timer
                    watch.Stop();

                    //Capture the elapsed ticks for object routines
                    objectTicks += watch.ElapsedTicks;

                    //Rest
                    watch.Reset();

                    //Print current values of volt, ohm, amps
                    if (print)
                    {
                        Console.WriteLine($"volts = {volt} ohm = {ohm} amps = {amps}");
                    }

                    //increment counter
                    count++;
                }

                //Print total times ohms was incremented
                Console.WriteLine($"Incremented ohms {count} times");
            }

            //How many ticks did static methods spend working vs object methods
            Console.WriteLine($"Total ticks in static methods: {staticTicks}");
            Console.WriteLine($"Total ticks creating and using objects: {objectTicks}");
        }
    }
}