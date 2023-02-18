using XX_Alexandria.Models;

namespace XX_Alexandria.UI.Commands.MainMenu
{
    internal class SearchCatalog : IMenuCommand
    {
        private Catalog catalog;

        public SearchCatalog(Catalog catalog)
        {
            this.catalog = catalog;
        }

        public void Execute()
        {
            Console.Write("Enter search term: ");

            string searchTerm = Console.ReadLine();

            List<CatalogItem> searchResults = catalog.Search(searchTerm);

            Console.Clear();

            Console.WriteLine($"Search Results for {searchTerm}");
            if (searchResults.Count == 0)
            {
                Console.WriteLine("No Results");
            }
            else
            {
                foreach (CatalogItem i in searchResults)
                {
                    Console.WriteLine(i);
                }
            }

            ConsoleHelper.PressAnyKey();
        }

        public bool IsExit()
        {
            return false;
        }

        public String GetCommandName()
        {
            return "Search Catalog";
        }
    }
}

