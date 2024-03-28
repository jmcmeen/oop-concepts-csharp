namespace _08_3_IComparer
{
    /// <summary>
    /// Models a monster
    /// </summary>
    internal class Monster
    {
        public string? Name { get; set; }
        public int HitPoints { get; set; }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Monster()
        {
        }

        /// <summary>
        /// Monster to string
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return $"{Name} {HitPoints}";
        }
    }
}
