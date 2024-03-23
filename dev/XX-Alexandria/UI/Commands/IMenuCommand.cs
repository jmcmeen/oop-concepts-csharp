namespace XX_Alexandria.UI.Commands
{
    internal interface IMenuCommand
    {
        void Execute();
        bool IsExit();
        string GetCommandName();
    }
}
