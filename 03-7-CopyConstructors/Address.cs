namespace _03_7_CopyConstructors
{
    internal class Address
    {
        public string Street { get; set; }
        public string City { get; set; }

        public Address()
        {
            Street = string.Empty;
            City = string.Empty;
        }

        public Address(Address other)
        {
            Street = other.Street;
            City = other.City;
        }
    }
}
