namespace _06_3_IComparer
{
    /// <summary>
    /// Comapares two Monster objects by Name
    /// </summary>
    internal class NameComparer : IComparer<Monster>
    {
        public int Compare(Monster? x, Monster? y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
