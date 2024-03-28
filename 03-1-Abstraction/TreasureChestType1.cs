namespace _03_1_Abstraction
{
    /// <summary>
    /// Models a TreasureChest that owns a Dictionary of Items
    /// </summary>
    internal class TreasureChestType1 : TreasureChest
    {
        //private fields
        private Dictionary<int, Item> items;

        /// <summary>
        /// Default constructor
        /// </summary>
        public TreasureChestType1()
        {
            items = new Dictionary<int, Item>();
        }

        /// <summary>
        /// Adds an Item to the TreasureChest
        /// </summary>
        /// <param name="item"></param>
        public override void AddItem(Item item)
        {
            items.Add(items.Count, item);
        }
    }
}
