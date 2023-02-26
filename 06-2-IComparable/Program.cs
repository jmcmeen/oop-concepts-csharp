namespace _06_SortingObjectLists
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

            monsterList.Sort();

            Console.WriteLine("\nPrint sorted list\n");
            PrintMonsters(monsterList);

            monsterList.Reverse();

            Console.WriteLine("\nPrint reversed list\n");
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