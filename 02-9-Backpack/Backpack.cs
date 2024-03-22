using System.Text;

namespace _03_7_Backpack
{
    /// <summary>
    /// Models a backpack
    /// </summary>
    internal class Backpack
    {
        //private fields
        private List<Item> _items;
        private uint _maxItems;

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="maxItems">Make items for backpack to hold</param>
        public Backpack(uint maxItems)
        {
            _items = new List<Item>();
            _maxItems = maxItems;
        }

        /// <summary>
        /// Adds an item to the backpack
        /// </summary>
        /// <param name="item">Item to be added</param>
        /// <exception cref="ArgumentNullException">If item passed in is null</exception>
        /// <exception cref="Exception">If the backpack is full</exception>
        public void AddItem(Item item)
        {
            //guard clauses
            if(item == null) throw new ArgumentNullException("item");
            if(_items.Count >= _maxItems) throw new Exception("Backpack is full!");

            //Add the item
            _items.Add(item);
        }

        /// <summary>
        /// Converts a Backpack to a string
        /// </summary>
        /// <returns>string representation of a Backpack</returns>
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
