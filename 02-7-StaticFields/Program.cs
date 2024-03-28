namespace _02_7_StaticFields
{
    /// <summary>
    /// Program to demonstrate static fields
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            TreasureChest tc = new TreasureChest("Larry");
            TreasureChest tc2 = new TreasureChest("Paula");
            TreasureChest t3 = new TreasureChest("Frank C.");

            Console.WriteLine(TreasureChest.numChests);
            Console.WriteLine(tc.GetNumChests());

            string s = "Hello World!";
        }
    }
}