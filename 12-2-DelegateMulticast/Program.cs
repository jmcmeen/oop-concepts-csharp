namespace _12_2_DelegateMulticast
{
    internal static class Program
    {
        static void Main()
        {
            MessageHandler messageHandler = LogMessage;
            messageHandler += PrintMessage;

            messageHandler("Hi");
            messageHandler("I am a method delegate");
            messageHandler("I am multicasting to two");
            messageHandler("count them");
            messageHandler("two methods at once!");
            messageHandler("check out the log.txt file in the bin folder");
        }

        delegate void MessageHandler(string message);

        static void LogMessage(string message)
        {
            File.AppendAllText("file.txt", message + "\n");
        }

        static void PrintMessage(string message) 
        {
            Console.WriteLine(message);
        }
    }
}
