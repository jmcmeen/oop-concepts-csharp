using System.Text.Json;

namespace _11_1_JSONSerialization
{
    internal class Program
    {
        static void Main(string[] args)
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

            //Now let's take that string, call Deserialize and turn this back into a set of object!
            TreasureChest? myNewTreasureChest = JsonSerializer.Deserialize<TreasureChest>(jsonString);

            //Behold an object reference!
            Console.WriteLine(myNewTreasureChest.items.Count);
        }
    }
}