using XX_Alexandria.UI.Commands.MainMenu;
using XX_Alexandria.UI;
using XX_Alexandria.Models;

namespace XX_Alexandria
{
    internal class Alexandria
    {
        static void Main()
        {
            ConsoleMenu menu = new ConsoleMenu("Welcome to the Alexandria Public Library");

            Catalog alexandria = new Catalog("APL");

            //menu.addCommand(new LoadLibraryFromFile(alexandria));
            //menu.addCommand(new SaveLibraryToFile(alexandria));
            menu.AddCommand(new AddCatalogItems(alexandria));
            menu.AddCommand(new SearchCatalog(alexandria));
            menu.AddCommand(new ShowAllItems(alexandria));
            //menu.addCommand(new AddItems(alexandria));
            menu.AddCommand(new ExitProgram());

            menu.show();
        }
    }
}