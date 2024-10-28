namespace _8_4_ICloneable
{
    internal static class Program
    {
        static void Main()
        {
            //First there is one Item
            Item itemOne = new Item("Sword", 235.2f);

            Console.WriteLine(itemOne);

            //Now we can create a copy using Item's Clone Method, since it implements the ICloneable interface
            Item? itemTwo = (Item)itemOne.Clone();

            itemTwo = itemOne.Clone() as Item;

            if (itemTwo != null)
            {
                Console.WriteLine(itemTwo);
            }
        }
    }
}