namespace _07_2_StaticFields
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreasureChest tc = new TreasureChest("Larry");
            TreasureChest tc2 = new TreasureChest("Paula");

            Console.WriteLine(TreasureChest.numChests);
        }
    }
}