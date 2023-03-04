namespace _07_3_Abstraction
{
    internal class TreasureChest2
    {
        public Dictionary<string, Item> items;

        public TreasureChest2()
        {
            items = new Dictionary<string, Item>();
        }

        public void AddItem(Item item)
        {
            items.Add($"{new Random().NextInt64(40000000000000)}", item);
        }
    }
}
