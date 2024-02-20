//references: https://learn.microsoft.com/en-us/dotnet/api/system.io.file?view=net-7.0

namespace _10_1_Files
{
    internal static class Program
    {
        public static void Main()
        {
            const string path = @"c:\temp.txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }
            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}