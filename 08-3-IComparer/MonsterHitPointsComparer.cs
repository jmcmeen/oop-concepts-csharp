namespace _08_3_IComparer
{
    /// <summary>
    /// Comparer which provides a method to compare two Monsters by HitPoints
    /// </summary>
    internal class MonsterHitPointsComparer : IComparer<Monster>
    {
        /// <summary>
        /// Compares two Monster objects by HitPoints
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Compare(Monster? x, Monster? y)
        {
            return x!.HitPoints - y!.HitPoints;
        }
    }
}
