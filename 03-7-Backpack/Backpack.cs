using System.Text;

namespace _03_7_BackpackComposition
{
    internal class Backpack
    {
        private List<Item> _items;
        private uint _maxItems;

        public Backpack(uint maxItems)
        {
            _items = new List<Item>();
            _maxItems = maxItems;
        }

        public void AddItem(Item item)
        {
            if (_items.Count < _maxItems)
            {
                _items.Add(item);
            }
            else
            {
                throw new Exception("Backpack is full!");
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach(Item item in _items)
            {
                sb.Append(item.ToString());
                sb.Append('\n');
            }

            return sb.ToString();
        }
    }
}
