using _11_1_CopyConstructors;

namespace _11_3_ICloneable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //First there is one Item
            Item itemOne = new Item("Sword", 235.2f);

            Console.WriteLine(itemOne);

            //Now we can create a copy using Item's Clone Method, since it implements the ICloneable interface
            Item itemTwo = (Item)itemOne.Clone();

            Console.WriteLine(itemTwo);
        }
    }
}