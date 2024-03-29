using System.Text;

namespace _09_3_FileEncoding
{
    internal static class Program
    {
        static void Main()
        {
            //TODO TEll them what youre doing and why
            const string textFilePath = @"textfile.txt";
            const string binaryFilePath = @"binaryfile.dat";
            int writeValue = int.MaxValue;
            int readValue = 0;

            //Creates a file if it does not exist
            if (!File.Exists(textFilePath))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(textFilePath))
                {
                    sw.Write(writeValue);
                }
            }

            // Open the file to read from.
            using (StreamReader sr = File.OpenText(textFilePath))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

            //creates a binary file
            using (var stream = File.Open(binaryFilePath, FileMode.Create))
            {
                using (var writer = new BinaryWriter(stream, Encoding.Default, false))
                {
                    writer.Write(writeValue);
                }
            }

            //reads a binary file
            if (File.Exists(binaryFilePath))
            {
                using (var stream = File.Open(binaryFilePath, FileMode.Open))
                {
                    using (var reader = new BinaryReader(stream, Encoding.Default, false))
                    {
                        readValue = reader.ReadInt32();
                    }
                }

                Console.WriteLine(readValue);
            }
        }
    }
}