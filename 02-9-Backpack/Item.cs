namespace _03_7_Backpack
{
    /// <summary>
    /// Models an item
    /// </summary>
    internal class Item
    {
        // public auto-implemented properties
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Effect { get; set; }
        public uint GoldPrice { get; set; }

        /// <summary>
        /// Converts an Item to a string
        /// </summary>
        /// <returns>string representation of an Item</returns>
        public override string ToString()
        {
            return $"Item: {Name}\nDescription: {Description}\n" +
                $"Effect: {Effect}\nGold Price: {GoldPrice}\n";
        }
    }
}
