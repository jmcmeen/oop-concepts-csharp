namespace _09_4_JSONSerialization
{
    internal class TreasureChest
    {
        public int ID { get; set; }
        public List<Item> items { get; set; }

        public TreasureChest()
        {
            items = new List<Item>();
        }
    }
}
