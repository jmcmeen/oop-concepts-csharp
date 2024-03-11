namespace _07_3_Abstraction
{
    /// <summary>
    /// Models a TreasureChest that owns a List of Items
    /// </summary>
    internal class TreasureChestType2 : TreasureChest
    {
        //private fields
        private List<Item> items;

        /// <summary>
        /// Default constructor
        /// </summary>
        public TreasureChestType2()
        {
            items = new List<Item>();
        }

        /// <summary>
        /// Adds an Item to the TreasureChest
        /// </summary>
        /// <param name="item"></param>
        public override void AddItem(Item item)
        {
            items.Add(item);
        }
    }
}
