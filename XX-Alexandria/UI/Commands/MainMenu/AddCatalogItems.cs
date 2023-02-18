using XX_Alexandria.Models;
using XX_Alexandria.UI.Commands.AddItemsMenu;

namespace XX_Alexandria.UI.Commands.MainMenu
{
    internal class AddCatalogItems : IMenuCommand
    {
        private const string COMMAND_NAME = "Add Catalog Items";

        private Catalog catalog;

        public AddCatalogItems(Catalog catalog)
        {
            this.catalog = catalog;
        }
        public void Execute()
        {
            ConsoleMenu menu = new ConsoleMenu(COMMAND_NAME);

            menu.AddCommand(new AddBook(catalog));
            menu.AddCommand(new AddFilm(catalog));
            menu.AddCommand(new AddPeriodical(catalog));
            menu.AddCommand(new ExitAddItems());

            menu.show();
        }

        public string GetCommandName()
        {
            return "Add Catalog Items";
        }

        public bool IsExit()
        {
            return false;
        }
    }
}
