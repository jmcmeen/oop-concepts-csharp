namespace _03_3_Aggregation
{
    /// <summary>
    /// Models a person
    /// </summary>
    internal class Person
    {
        public string Name { get; set; }

        public Address Address { get; set; }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="name">person name</param>
        /// <param name="address">person address</param>
        public Person(string name, Address address)
        {
            Name = name;
            Address = address;
        }
    }
}
