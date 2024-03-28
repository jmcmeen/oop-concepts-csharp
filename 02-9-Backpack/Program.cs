namespace _02_9_Backpack
{
    /// <summary>
    /// Program demonstrating a Backpack class which encapsulates a List of Items.
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        static void Main()
        {
            //create a backpack
            Backpack b = new Backpack(3);

            //Create an item, set up using properties
            Item item = new Item();
            item.Name = "Whispering Dagger";
            item.Description = "A slender, silver blade adorned with intricate runes.";
            item.Effect = "When whispered to, it reveals hidden truths and secrets.";
            item.GoldPrice = 3000;

            //try to add the item
            try
            {
                b.AddItem(item);
                Console.WriteLine("Item added.\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //create an item, using an object initializer, reuse reference
            item = new Item()
            {
                Name = "Spectral Lutebow",
                Description = "A hybrid instrument—a lute and a crossbow merged into one.",
                Effect = "Strumming its strings fires ethereal arrows that never miss their mark.",
                GoldPrice = 5000,
            };

            //try to add the item
            try
            {
                b.AddItem(item);
                Console.WriteLine("Item added.\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //create an item using object initializer passed straight into backpack add method
            //try to add the item
            try
            {
                b.AddItem(new Item()
                {
                    Name = "Potion of Serpent’s Brew",
                    Description = "A bubbling bottle filled with iridescent liquid.",
                    Effect = "Drinking from it grants the ability to speak and understand the language of snakes.",
                    GoldPrice = 200,
                });
                Console.WriteLine("Item added.\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            //Our backpack of 3 is full, this should catch the exception
            //create an item using object initializer passed straight into backpack add method
            //try to add the item
            try
            {
                b.AddItem(new Item()
                {
                    Name = "Chalice of Time’s Embrace",
                    Description = "A crystal goblet with shifting sands inside.",
                    Effect = "Sipping from it allows glimpses into the past or future",
                    GoldPrice = 100,
                });


                Console.WriteLine("Item added.\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\n");
            }

            //Print backpack (Console.WriteLine will call Backpack's ToString method)
            Console.WriteLine(b);
        }
    }
}
