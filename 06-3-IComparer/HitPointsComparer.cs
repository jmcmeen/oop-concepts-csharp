﻿namespace _06_3_IComparer
{
    /// <summary>
    /// Comparer which provides a method to compare two Monsters by HitPoints
    /// </summary>
    internal class HitPointsComparer : IComparer<Monster>
    {
        /// <summary>
        /// Compares two Monster objects by HitPoints
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public int Compare(Monster? x, Monster? y)
        {
            if(x.HitPoints > y.HitPoints)
            {
                return 1;
            }
            else if(x.HitPoints < y.HitPoints)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
