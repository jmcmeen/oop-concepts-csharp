namespace _06_3_IComparer
{
    internal class HitPointsComparer : IComparer<Monster>
    {
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
