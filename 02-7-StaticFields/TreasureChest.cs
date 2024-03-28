namespace _02_7_StaticFields
{
    /// <summary>
    /// Models a TreasureChest
    /// </summary>
    internal class TreasureChest
    {
        //public auto-implemented properties
        public static int numChests { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="name"></param>
        public TreasureChest(string name)
        {
            Name = name;
            numChests++;
        }

        public int GetNumChests() { return numChests; }
    }
}
