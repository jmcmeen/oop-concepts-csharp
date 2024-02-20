namespace _01_2_AutoProperties
{
    /// <summary>
    /// Models loot
    /// </summary>
    internal class Loot
    {
        // public auto-properties
        public string Name{ get; set; }
        public uint Price{ get; set; }

        //public methods

        /// <summary>
        /// Default constructor
        /// </summary>
        public Loot() {

            Name = "";
            Price = 0;
        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="name">loot name</param>
        /// <param name="price">loot price</param>
        public Loot(string name, uint price)
        {
            Name = name;
            Price = price;
        }

        /// <summary>
        /// Converts a Loot object to a string
        /// </summary>
        /// <returns>string representation of Loot</returns>
        public override string ToString()
        {
            return $"name: {Name}, price: {Price}";
        }
    }
}
