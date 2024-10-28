namespace _8_4_ICloneable
{
    internal class Item : ICloneable
    {
        public string? Description { get; set; }

        public float Cost { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Item() { }

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
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string? ToString()
        {
            return $"{Description} {Cost}";
        }

        /// <summary>
        /// Clone
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            //create and return a new Item reference, passing in this Item's properties
            return new Item(Description, Cost);
        }
    }
}
