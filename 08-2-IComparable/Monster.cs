namespace _08_2_IComparable
{
    /// <summary>
    /// Models a Monster, implementing the IComparable interface
    /// </summary>
    internal class Monster : IComparable<Monster>
    {
        //private fields
        private const int MIN_HP = 100;
        private const int MAX_HP = 200;

        //public auto-implemented properties
        public string Name { get; set; }
        public int HitPoints { get; set; }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="name"></param>
        public Monster(string name)
        {
            Random r = new Random();
            Name = name;

            HitPoints = r.Next(MIN_HP, MAX_HP + 1);
        }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="hitPoints"></param>
        public Monster(string name, int hitPoints)
        {
            Name = name;
            HitPoints = hitPoints;
        }

        /// <summary>
        /// Converts Monster to string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"{Name} {HitPoints}";
        }

        /// <summary>
        /// Compares Monster based on Name property
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Monster? other)
        {
            if (other == null) throw new ArgumentNullException("other");
            return Name.CompareTo(other.Name);
        }
    }
}
