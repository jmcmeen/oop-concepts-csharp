﻿/// File: Loot.cs
/// Name: John McMeen 
/// Email: jnmcmeen@northeaststate.edu
/// Project: CISP 1020 Examples
namespace _01_Properties
{
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
        /// Prameterized constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
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
