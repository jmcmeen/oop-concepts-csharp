namespace _06_3_IComparer
{
    internal class Program
    {
        static void Main()
        {
            List<Monster> monsterList = new List<Monster>();

            for(int i = 0; i < 25; i++)
            {
                monsterList.Add(new Monster());
            }

            Console.WriteLine("Print unsorted list\n");
            PrintMonsters(monsterList);

            monsterList.Sort(new HitPointsComparer());

            Console.WriteLine("\nPrint sorted by HitPoints list\n");
            PrintMonsters(monsterList); 
            
            monsterList.Sort(new NameComparer());

            Console.WriteLine("\nPrint sorted by Name list\n");
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