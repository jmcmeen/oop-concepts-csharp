namespace _06_3_IComparer
{
    /// <summary>
    /// Models a monster
    /// </summary>
    internal class Monster
    {
        private const int MIN_HP = 100;
        private const int MAX_HP = 200;
        public string Name { get; set; }
        public int HitPoints { get; set; }

        /// <summary>
        /// Default constructor creates a random Monster
        /// </summary>
        public Monster()
        {
            Random r = new Random();
            Name = RandomGen.NextName(8);

            HitPoints = r.Next(MIN_HP, MAX_HP);
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
