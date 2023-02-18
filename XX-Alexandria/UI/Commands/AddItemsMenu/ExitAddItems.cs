namespace XX_Alexandria.UI.Commands.AddItemsMenu
{
    internal class ExitAddItems : IMenuCommand
    {
        private const string COMMAND_NAME = "Exit Menu";
        public void Execute()
        {
        }

        public string GetCommandName()
        {
            return COMMAND_NAME;
        }

        public bool IsExit()
        {
            return true;
        }
    }
}
