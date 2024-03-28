namespace _04_6_HashCode
{
    internal class Loot
    {
        public string name;
        public double cost;

        public override int GetHashCode()
        {
            return HashCode.Combine(name, cost);
        }
    }
}
