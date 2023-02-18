using XX_Alexandria.Models;

namespace XX_Alexandria.UI.Commands.AddItemsMenu
{
    internal class AddBook : IMenuCommand
    {
        private const string COMMAND_NAME = "Add Book";

        private Catalog catalog;

        public AddBook(Catalog catalog) 
        {
            this.catalog = catalog;
        }

        public void Execute()
        {
            Console.WriteLine(COMMAND_NAME);

            string id;
            string year;
            string title;
            string author;
            string ISBN;
            BookType bookType;

            Console.Write("Enter book ID: ");
            id = Console.ReadLine();
            Console.Write("Enter book title: ");
            title = Console.ReadLine();
            Console.Write("Enter book year: ");
            year = Console.ReadLine();
            Console.Write("Enter book author: ");
            author = Console.ReadLine();
            Console.Write("Enter book ISBN: ");
            ISBN = Console.ReadLine();

            Console.WriteLine("\nEnter value for book type: ");

            foreach(var v in Enum.GetValues(typeof(BookType)))
            {
                Console.Write($"{v} [{(int)v}] ");
            }

            bookType = (BookType)Int32.Parse(Console.ReadLine());

            catalog.AddItem(new Book(id, title, year, author, ISBN, bookType));
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
