﻿namespace _03_3_Aggregation
{
    internal class Person
    {
        public string Name { get; set; }

        public Address Address { get; set; }

        public Person(string name, Address address)
        {
            Name = name;
            Address = address;
        }
    }
}
