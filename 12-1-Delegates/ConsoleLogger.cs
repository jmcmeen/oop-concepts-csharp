namespace _12_1_Delegates
{
    internal class ConsoleLogger
    {
        public delegate void PrintLine(string message);
        public PrintLine Print {  get; set; }

        public ConsoleLogger() 
        {
            Print = PrintNormal;
        }

        public void PrintNormal(string message)
        {
            Console.WriteLine(message);
        }

        public void PrintLower(string message) { Console.WriteLine(message.ToLower());}

        public void PrintUpper(string message) { Console.WriteLine(message.ToUpper());}
        public void PrintAlternatingCase(string message)
        {
            int counter = 0;
            foreach (char c in message)
            {
                Console.Write(counter % 2 == 0 ? c.ToString().ToLower() : c.ToString().ToUpper());
                counter++;
            }
            Console.WriteLine();
        }
    }
}
