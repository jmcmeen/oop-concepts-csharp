namespace _03_7_BackpackComposition
{
    internal class Item
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Effect { get; set; }
        public uint GoldPrice { get; set; }

        public override string ToString()
        {
            return $"Item: {Name}\nDescription: {Description}\n" +
                $"Effect: {Effect}\nGold Price: {GoldPrice}\n";
        }
    }
}
