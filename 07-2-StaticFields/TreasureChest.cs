namespace _07_2_StaticFields
{
    internal class TreasureChest
    {
        public static int numChests { get; set; }
        public string Name { get; set; }

        public TreasureChest(string name) {
            Name = name;
            numChests++;
        }
    }
}
