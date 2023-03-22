namespace _09_1_Equals
{
    internal class Loot
    {
        public string name;
        public double cost;

        public override bool Equals(object? obj)
        {
            return obj is Loot loot &&
                   name == loot.name &&
                   cost == loot.cost;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(name, cost);
        }
    }
}
