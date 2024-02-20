namespace _01_1_Objects
{
    /// <summary>
    /// Models in game loot
    /// </summary>
    internal class Loot
    {
        //private fields
        private string name;
        private uint price;

        //public methods

        /// <summary>
        /// Default constructor
        /// </summary>
        public Loot() {

            name = "";
            price = 0;
        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public Loot(string name, uint price)
        {
            this.name = name;
            this.price = price;
        }

        /// <summary>
        /// Sets the private name field
        /// </summary>
        /// <param name="name"></param>
        public void SetName(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// Gets the private name field
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// Sets the private price field
        /// </summary>
        /// <param name="price"></param>
        public void SetPrice(uint price)
        {
            this.price = price;
        }

        /// <summary>
        /// Gets the private price field
        /// </summary>
        /// <returns></returns>
        public uint GetPrice()
        {
            return price;
        }

        /// <summary>
        /// Converts a Loot object to a string
        /// </summary>
        /// <returns>string representation of Loot</returns>
        public override string ToString()
        {
            return $"name: {name}, price: {price}";
        }
    }
}
