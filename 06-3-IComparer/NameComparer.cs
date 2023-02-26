namespace _06_3_IComparer
{
    internal class NameComparer : IComparer<Monster>
    {
        public int Compare(Monster? x, Monster? y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
