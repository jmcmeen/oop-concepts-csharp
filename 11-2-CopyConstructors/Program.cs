﻿namespace _11_1_CopyConstructors
{
    internal class Program
    {
        static void Main(string[] args)
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