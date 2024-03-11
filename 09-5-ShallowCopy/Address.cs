namespace _11_4_ShallowCopy
{
    internal class Address
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
    }
}
