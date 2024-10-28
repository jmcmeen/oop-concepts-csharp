namespace _08_3_IComparer
{
    /// <summary>
    /// Comparer which provides a method to compare two Monsters by Name
    /// </summary>
    internal class MonsterNameComparer : IComparer<Monster>
    {
        /// <summary>
        /// Compares two Monster objects by Name
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Compare(Monster? x, Monster? y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
