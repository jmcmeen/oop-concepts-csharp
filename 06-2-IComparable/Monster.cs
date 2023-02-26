namespace _06_SortingObjectLists
{
    internal class Monster : IComparable<Monster>
    {
        private const int MIN_HP = 100;
        private const int MAX_HP = 200;
        public string Name { get; set; }
        public int HitPoints { get; set; }

        public Monster(string name)
        {
            Random r = new Random();
            Name = name;

            HitPoints = r.Next(MIN_HP, MAX_HP + 1);
        }

        public Monster(string name, int hitPoints)
        {
            Name = name;
            HitPoints = hitPoints;
        }

        public override string ToString()
        {
            return $"{Name} {HitPoints}";
        }

        public int CompareTo(Monster? other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
