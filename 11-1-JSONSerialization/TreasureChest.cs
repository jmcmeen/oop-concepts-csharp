using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_1_JSONSerialization
{
    internal class TreasureChest
    {
        public int ID { get; set; }
        public List<Item> items { get; set; }

        public TreasureChest() 
        {
            items = new List<Item>();    
        }
    }
}
