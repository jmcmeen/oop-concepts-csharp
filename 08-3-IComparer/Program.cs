namespace _06_3_IComparer
{
    /// <summary>
    /// Program demonstrating sorting a list with a Comparer
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            List<Monster> monsterList = new List<Monster>();

            for(int i = 0; i < 25; i++)
            {
                monsterList.Add(RandomGen.NextMonster());
            }

            Console.WriteLine("Print unsorted List\n");
            PrintMonsters(monsterList);

            monsterList.Sort(new HitPointsComparer());

            Console.WriteLine("\nPrint List sorted by HitPoints\n");
            PrintMonsters(monsterList); 
            
            monsterList.Sort(new NameComparer());

            Console.WriteLine("\nPrint List sorted by Name\n");
            PrintMonsters(monsterList);
        }

        static void PrintMonsters(List<Monster> monsterList)
        {
            foreach (Monster monster in monsterList)
            {
                Console.WriteLine(monster);
            }
        }
    }
}