namespace _8_5_ShallowCopy
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
            //This is a shallow copy because Address is a reference, so clones will all have references to the same Address in memory
            return new Person
            {
                Name = Name,
                Address = Address
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string? ToString()
        {
            return $"{Name} {Address}";
        }
    }
}
