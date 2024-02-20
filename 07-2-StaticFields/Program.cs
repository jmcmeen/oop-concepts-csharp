namespace _07_2_StaticFields
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

            Console.WriteLine(TreasureChest.numChests);
        }
    }
}