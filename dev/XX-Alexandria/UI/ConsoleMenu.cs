using XX_Alexandria.UI.Commands;

namespace XX_Alexandria.UI
{
    internal class ConsoleMenu
    {
        private string menuHeader;
        private Dictionary<int, IMenuCommand> commandDictionary;

        public ConsoleMenu(string menuHeader)
        {
            commandDictionary = new Dictionary<int, IMenuCommand>();
            this.menuHeader = menuHeader;
        }

        public void AddCommand(IMenuCommand command)
        {
            commandDictionary.Add(commandDictionary.Count + 1, command);
        }

        public void show()
        {
            IMenuCommand c;

            do
            {
                if (commandDictionary.Count == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Empty Menu");
                    ConsoleHelper.PressAnyKey();
                    Console.Clear();
                    break;
                }

                Console.WriteLine(menuHeader);

                // Using for-each loop
                foreach (var (key, value) in commandDictionary)
                {
                    Console.WriteLine(key + ". " + value.GetCommandName());
                }

                Console.Write("Choose a number and press enter: ");
                int input = Int32.Parse(Console.ReadLine());

                while (!commandDictionary.ContainsKey(input))
                {
                    Console.WriteLine("Invalid choice. Choose a number and press enter: ");
                    input = Int32.Parse(Console.ReadLine());
                }

                Console.Clear();

                c = commandDictionary[input];

                c.Execute();

                Console.Clear();

            } while (!c.IsExit());
        }
    }
}
