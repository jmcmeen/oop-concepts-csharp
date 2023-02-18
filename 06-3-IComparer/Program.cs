namespace _06_3_IComparer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Monster> monsterList = new List<Monster>();

            monsterList.Add(new Monster("Orc"));
            monsterList.Add(new Monster("Troll"));
            monsterList.Add(new Monster("Ogre"));
            monsterList.Add(new Monster("Dragon"));
            monsterList.Add(new Monster("Golem"));

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