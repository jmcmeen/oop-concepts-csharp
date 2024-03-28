namespace _03_1_Abstraction
{
    /// <summary>
    /// Program that demonstrates Abstraction
    /// </summary>
    internal static class Program
    {
        static void Main()
        {
            Random random = new Random();

            List<TreasureChest> treasureChests = new List<TreasureChest>();

            treasureChests.Add(new TreasureChestType1());
            treasureChests.Add(new TreasureChestType2());

            foreach (TreasureChest treasureChest in treasureChests)
            {
                var numItemsToAdd = random.Next(1, 11);
                for (int i = 0; i < numItemsToAdd; i++)
                {
                    treasureChest.AddItem(new Item());
                }
            }

            Console.WriteLine();
        }
    }
}