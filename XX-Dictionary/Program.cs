// References: https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=net-7.0

namespace XX_Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a new dictionary of ints, with string keys.
            //
            Dictionary<int, string> menuItems =
                new Dictionary<int, string>();

            // Add some elements to the dictionary. There are no
            // duplicate keys, but some of the values are duplicates.
            menuItems.Add(1, "New Game");
            menuItems.Add(2, "Load Game");
            menuItems.Add(3, "Create Character");
            menuItems.Add(4, "Create Character");

            // The Add method throws an exception if the new key is
            // already in the dictionary.
            try
            {
                menuItems.Add(1, "Create Character");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("An element with Key = \"1\" already exists.");
            }

            // The Item property is another name for the indexer, so you
            // can omit its name when accessing elements.
            Console.WriteLine("For key = \"1\", value = {0}.",
                menuItems[1]);

            // The indexer can be used to change the value associated
            // with a key.
            menuItems[4] = "Buy DLC";
            Console.WriteLine("For key = \"4\", value = {0}.",
                menuItems[4]);

            // If a key does not exist, setting the indexer for that key
            // adds a new key/value pair.
            menuItems[5] = "Exit";

            // The indexer throws an exception if the requested key is
            // not in the dictionary.
            try
            {
                Console.WriteLine("For key = \"6\", value = {0}.",
                    menuItems[6]);
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("Key = \"6\" is not found.");
            }

            // When a program often has to try keys that turn out not to
            // be in the dictionary, TryGetValue can be a more efficient
            // way to retrieve values.
            string value = "";
            if (menuItems.TryGetValue(6, out value))
            {
                Console.WriteLine("For key = \"6\", value = {0}.", value);
            }
            else
            {
                Console.WriteLine("Key = \"6\" is not found.");
            }

            // ContainsKey can be used to test keys before inserting
            // them.
            if (!menuItems.ContainsKey(6))
            {
                menuItems.Add(6, "Secret Menu");
                Console.WriteLine("Value added for key = \"6\": {0}",
                    menuItems[6]);
            }

            // When you use foreach to enumerate dictionary elements,
            // the elements are retrieved as KeyValuePair objects.
            Console.WriteLine();
            foreach (KeyValuePair<int, string> kvp in menuItems)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    kvp.Key, kvp.Value);
            }

            // To get the values alone, use the Values property.
            Dictionary<int, string>.ValueCollection valueColl =
                menuItems.Values;

            // The elements of the ValueCollection are strongly typed
            // with the type that was specified for dictionary values.
            Console.WriteLine();
            foreach (string s in valueColl)
            {
                Console.WriteLine("Value = {0}", s);
            }

            // To get the keys alone, use the Keys property.
            Dictionary<int, string>.KeyCollection keyColl =
                menuItems.Keys;

            // The elements of the KeyCollection are strongly typed
            // with the type that was specified for dictionary keys.
            Console.WriteLine();
            foreach (int i in keyColl)
            {
                Console.WriteLine("Key = {0}", i);
            }

            // Use the Remove method to remove a key/value pair.
            Console.WriteLine("\nRemove(\"6\")");
            menuItems.Remove(6);

            if (!menuItems.ContainsKey(6))
            {
                Console.WriteLine("Key \"6\" is not found.");
            }
        }
    }
}