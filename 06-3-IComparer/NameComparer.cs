using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
