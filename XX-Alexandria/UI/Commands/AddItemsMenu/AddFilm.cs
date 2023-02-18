using XX_Alexandria.Models;

namespace XX_Alexandria.UI.Commands.AddItemsMenu
{
    internal class AddFilm : IMenuCommand
    {
        private const string COMMAND_NAME = "Add Film";

        private Catalog catalog;

        public AddFilm(Catalog catalog)
        {
            this.catalog = catalog;
        }

        public void Execute()
        {
            Console.WriteLine(COMMAND_NAME);

            string id;
            string year;
            string title;
            string director;
            FilmType filmType;

            Console.Write("Enter film ID: ");
            id = Console.ReadLine();
            Console.Write("Enter film title: ");
            title = Console.ReadLine();
            Console.Write("Enter film year: ");
            year = Console.ReadLine();
            Console.Write("Enter film director: ");
            director = Console.ReadLine();

            Console.WriteLine("\nEnter value for film type: ");

            foreach (var v in Enum.GetValues(typeof(FilmType)))
            {
                Console.Write($"{v} [{(int)v}] ");
            }

            filmType = (FilmType)Int32.Parse(Console.ReadLine());

            catalog.AddItem(new Film(id, title, year, director, filmType));
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
