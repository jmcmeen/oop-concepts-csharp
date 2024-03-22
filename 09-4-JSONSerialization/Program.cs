using System.Text.Json;

namespace _09_4_JSONSerialization
{
    internal static class Program
    {
        static void Main()
        {
            //create a TreasureChest
            TreasureChest tc = new TreasureChest();

            //Add some Items to the TreasureChest's public item list (abstracting this to a TreasureChest method would be nicer)
            tc.items.Add(new Item { Cost = 25, Description = "Hammer" });
            tc.items.Add(new Item { Cost = 2, Description = "Nail" });
            tc.items.Add(new Item { Cost = 45, Description = "Wool" });
            tc.items.Add(new Item { Cost = 100, Description = "Cheese" });

            //Wave your JSON wand, invoke the Serialize method, and turn this thing into a String in JSON form!
            string jsonString = JsonSerializer.Serialize(tc);

            //Behold! JSON!
            Console.WriteLine(jsonString);

            //now your objects are portable, and could be sent across a web api or stored in a file for later retrieval.
            //lets save to a file

            const string path = "temp.txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.Write(jsonString);
                }
            }

            //now let's read that back in from the file and recreate our objects
            // Open the file to read from.
            string fileText = File.ReadAllText(path);
            
            //Now let's take that string, call Deserialize and turn this back into a set of object!
            TreasureChest? myNewTreasureChest = JsonSerializer.Deserialize<TreasureChest>(fileText);

            //There is a possibility this call will return null if a deserialization issues arise
            if (myNewTreasureChest != null)
            {
                //Behold an object reference!
                Console.WriteLine(myNewTreasureChest.items.Count);
            }
        }
    }
}