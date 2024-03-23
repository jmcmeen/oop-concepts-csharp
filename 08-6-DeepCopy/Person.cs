namespace _11_5_DeepCopy
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
                Name = this.Name,
                Address = (Address)this.Address.Clone()
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
