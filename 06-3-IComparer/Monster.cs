namespace _06_3_IComparer
{
    internal class Monster
    {
        private const int MIN_HP = 100;
        private const int MAX_HP = 200;
        public string Name { get; set; }
        public int HitPoints { get; set; }

        public Monster(string name)
        {
            Random r = new Random();
            Name = name;

            HitPoints = r.Next(MIN_HP, MAX_HP);
        }

        public override string ToString()
        {
            return $"{Name} {HitPoints}";
        }
    }
}
