namespace _03_7_CopyConstructors
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }

        public Person(int id, string name, Address a)
        {
            Id = id;
            Name = name;
            Address = a;
        }

        public Person(Person other)
        {
            Id = other.Id;
            Name = other.Name;  
            Address = new Address(other.Address);
        }
    }
}
