namespace _11_2_CopyConstructors
{
    internal class Item
    {
        public string? Description { get; set; }

        public float Cost { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Item(){}

        /// <summary>
        /// Parametrized constructor
        /// </summary>
        /// <param name="description"></param>
        /// <param name="cost"></param>
        public Item(string? description, float cost)
        {
            Description = description;
            Cost = cost;
        }

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="item"></param>
        public Item(Item item)
        {
            //copy each of the values from item to this
            this.Description = item.Description;
            this.Cost = item.Cost;
        }

        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string? ToString()
        {
            return $"{Description} {Cost}";
        }
    }
}
