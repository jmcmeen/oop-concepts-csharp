namespace _09_1_Equals
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
