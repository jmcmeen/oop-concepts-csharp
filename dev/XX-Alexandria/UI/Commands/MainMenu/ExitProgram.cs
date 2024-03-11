namespace XX_Alexandria.UI.Commands.MainMenu
{
    internal class ExitProgram : IMenuCommand
    {
        const string COMMAND_NAME = "Exit";

        public void Execute()
        {
            Console.WriteLine("Exiting");
        }

        public string GetCommandName()
        {
            return COMMAND_NAME;
        }

        public bool IsExit()
        {
            return true; ;
        }
    }
}
