using XX_Alexandria.Models;

namespace XX_Alexandria.UI.Commands.AddItemsMenu
{
    internal class AddPeriodical : IMenuCommand
    {
        private const string COMMAND_NAME = "Add Periodical";

        private Catalog catalog;

        public AddPeriodical(Catalog catalog)
        {
            this.catalog = catalog;
        }

        public void Execute()
        {
            Console.WriteLine(COMMAND_NAME);

            string id;
            string year;
            string title;
            string volume;
            string issue;
            PeriodicalType periodicalType;

            Console.Write("Enter periodical ID: ");
            id = Console.ReadLine();
            Console.Write("Enter periodical title: ");
            title = Console.ReadLine();
            Console.Write("Enter periodical year: ");
            year = Console.ReadLine();
            Console.Write("Enter periodical volume: ");
            volume = Console.ReadLine();
            Console.Write("Enter periodical issue: ");
            issue = Console.ReadLine();

            Console.WriteLine("\nEnter value for periodical type: ");

            foreach (var v in Enum.GetValues(typeof(PeriodicalType)))
            {
                Console.Write($"{v} [{(int)v}] ");
            }

            periodicalType = (PeriodicalType)Int32.Parse(Console.ReadLine());

            catalog.AddItem(new Periodical(id, title, year, volume, issue, periodicalType));
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
