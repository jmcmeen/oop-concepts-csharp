namespace _11_2_CopyConstructors
{
    internal static class Program
    {
        static void Main()
        {
            //First there is one Item
            Item itemOne = new Item("Hammer", 25.2f);

            Console.WriteLine(itemOne);

            //Now we can create a copy using Item's copy constructor, passing in the first Item
            Item itemTwo = new Item(itemOne);

            Console.WriteLine(itemTwo);            
        }
    }
}