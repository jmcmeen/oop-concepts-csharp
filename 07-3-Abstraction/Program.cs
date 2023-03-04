namespace _07_3_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreasureChest1 t1 = new TreasureChest1();
            t1.items[0] = new Item();
            t1.items[1] = new Item();
            t1.items[2] = new Item();


            TreasureChest2 t2 = new TreasureChest2();
            t2.AddItem(new Item());
            t2.AddItem(new Item());
            t2.AddItem(new Item());

            Console.WriteLine();
        }
    }
}