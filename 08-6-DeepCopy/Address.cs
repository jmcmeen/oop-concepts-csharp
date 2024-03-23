namespace _11_5_DeepCopy
{
    internal class Address : ICloneable
    {
        public string? Street { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zip { get; set; }


        /// <summary>
        /// ToString
        /// </summary>
        /// <returns></returns>
        public override string? ToString()
        {
            return $"{Street} {City} {State} {Zip}";
        }

        /// <summary>
        /// Clone
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return new Address
            {
                Street = this.Street,
                City = this.City,
                State = this.State,
                Zip = this.Zip
            };
        }
    }
}
