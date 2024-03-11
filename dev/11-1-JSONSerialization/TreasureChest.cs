namespace _11_1_JSONSerialization
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
