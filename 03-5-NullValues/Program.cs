using LabUtils;

namespace _03_5_NullValues
{
    /// <summary>
    /// Program demonstrating nullable types
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application
        /// </summary>
        static void Main()
        {
            /*
             * In C#, null is a special value that indicates that a variable has no value.
             * Reference types (classes, structs, interfaces, delegates, and arrays) can be assigned null,
             * but value types cannot, such as integers, Booleans, and strings.
             * */

#pragma warning disable CS0168 // Variable is declared but never used
            int y;
#pragma warning restore CS0168 // Variable is declared but never used

            //Console.WriteLine(y);

            // Reference types can be assigned null.
#pragma warning disable CS0168 // Variable is declared but never used
            Dice dice;
#pragma warning restore CS0168 // Variable is declared but never used

            //The following statement will not compile.
            //int x = null;

            /* C# will allow you to assign null to a value type if you 
             * explicitly declare it as nullable.The following statement will compile. */
#pragma warning disable CS0219 // Variable is assigned but its value is never used
            int? x = null;
#pragma warning restore CS0219 // Variable is assigned but its value is never used

            /* The Stats class uses the ? modifier to indicate it's int properties are nullable.*/
            Stats stats = new Stats()
            {
                Strength = null,
                Dexterity = null,
                Constitution = null,
                Intelligence = null,
                Wisdom = null,
                Charisma = null
            };

            Console.WriteLine(stats.Strength);

            //This will be especially useful when working with data from a database where null is a valid value.
        }
    }
}
