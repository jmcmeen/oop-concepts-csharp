namespace _03_3_Aggregation
{
    internal class Address
    {
        public string Line1;
        public string Line2;
        public string City;
        public string State;
        public string Zip;

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
