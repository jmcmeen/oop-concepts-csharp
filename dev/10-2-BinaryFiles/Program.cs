using System.IO;
using System.Text;

namespace _10_2_BinaryFiles
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            const string fileName = @"c:\temp.dat";

            using (var stream = File.Open(fileName, FileMode.Create))
            {
                using (var writer = new BinaryWriter(stream, Encoding.UTF8, false))
                {
                    writer.Write(1.250F);
                    writer.Write(@"c:\Temp");
                    writer.Write(10);
                    writer.Write(true);
                }
            }

            float aspectRatio;
            string tempDirectory;
            int autoSaveTime;
            bool showStatusBar;

            if (File.Exists(fileName))
            {
                using (var stream = File.Open(fileName, FileMode.Open))
                {
                    using (var reader = new BinaryReader(stream, Encoding.UTF8, false))
                    {
                        aspectRatio = reader.ReadSingle();
                        tempDirectory = reader.ReadString();
                        autoSaveTime = reader.ReadInt32();
                        showStatusBar = reader.ReadBoolean();
                    }
                }

                Console.WriteLine("Aspect ratio set to: " + aspectRatio);
                Console.WriteLine("Temp directory is: " + tempDirectory);
                Console.WriteLine("Auto save time set to: " + autoSaveTime);
                Console.WriteLine("Show status bar: " + showStatusBar);
            }
        }
    }
}