namespace _8_6_DeepCopy
{
    internal class Person : ICloneable
    {
        public string? Name { get; set; }
        public Address? Address { get; set; }

        /// <summary>
        /// Clone
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            //This is a deep copy because Address's Clone creates a new object and returns it
            return new Person
            {
                Name = Name,
                Address = (Address)Address.Clone()
            };
        }

        /// <summary>
        /// Returns a string that represents the Person
        /// </summary>
        /// <returns></returns>
        public override string? ToString()
        {
            return $"{Name} {Address}";
        }
    }
}
