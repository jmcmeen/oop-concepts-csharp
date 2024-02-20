namespace _03_3_Aggregation
{
    /// <summary>
    /// Models an address
    /// </summary>
    internal class Address
    {
        public string Line1;
        public string Line2;
        public string City;
        public string State;
        public string Zip;

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="line1">address line 1</param>
        /// <param name="line2">address line 2</param>
        /// <param name="city">address city</param>
        /// <param name="state">address state</param>
        /// <param name="zipcode">address zip code</param>
        public Address(string line1, string line2, string city, string state, string zipcode)
        {
            this.Line1 = line1;
            this.Line2 = line2;
            this.City = city;
            this.State = state;
            this.Zip = zipcode;
        }
    }
}
