using XX_Alexandria.Models;

namespace XX_Alexandria.UI.Commands.MainMenu
{
    internal class ShowAllItems : IMenuCommand
    {
        private const string COMMAND_NAME = "Show All Catalog Items";
        private Catalog catalog;
        public ShowAllItems(Catalog catalog)
        {
            this.catalog = catalog;
        }

        public void Execute()
        {
            if (catalog.NumItems != 0)
            {
                foreach (CatalogItem c in catalog.Items)
                {
                    Console.WriteLine(c);
                }
            }
            else
            {
                Console.WriteLine("Catalog Empty");
            }



            ConsoleHelper.PressAnyKey();
        }

        public string GetCommandName()
        {
            return COMMAND_NAME;
        }

        public bool IsExit()
        {
            return false;
        }
    }
}
