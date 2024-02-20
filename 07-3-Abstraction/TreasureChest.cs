namespace _07_3_Abstraction
{
    /// <summary>
    /// Models an abstract TreasureChest
    /// </summary>
    internal abstract class TreasureChest
    {
        /// <summary>
        /// Add an Item to the TreasureChest
        /// </summary>
        /// <param name="item"></param>
        public abstract void AddItem(Item item);
    }
}
