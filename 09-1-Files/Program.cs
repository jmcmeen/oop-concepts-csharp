namespace _09_1_Files
{
    /// <summary>
    /// Demonstrates writing text files
    /// </summary>
    internal static class Program
    {
        /// <summary>
        /// Program entry point
        /// </summary>
        public static void Main()
        {
            // Example 1 - Reading and writing text files
            
            //Write a text file
            const string path = "temp.txt";
            string output = "Hello\nAnd\nWelcome";

            File.WriteAllText(path, output);

            //Read a text file
            string input = File.ReadAllText(path);

            Console.WriteLine(input);

            //Example 2 - Reading and writing text files line by line
            const string path2 = "temp2.txt";

            // Create a file to write to line by line
            using (StreamWriter sw = File.CreateText(path2))
            {
                sw.WriteLine("Hello");
                sw.WriteLine("And");
                sw.WriteLine("Welcome");
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(i.ToString());
                }
            }

            //create a variable to hold each line in the iteration below
            string s;

            //clear out input to reuse
            input = "";

            // Open the file to read from line by line
            using (StreamReader sr = File.OpenText(path2))
            {
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                    input += s + "\n";
                }
            }

            Console.WriteLine(input);
        }
    }
}