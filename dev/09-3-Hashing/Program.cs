using System.Security.Cryptography;
using System.Text;

namespace _09_03_Hashing
{
    internal static class Program
    {
        static void Main()
        {
            Encoding encoding = Encoding.ASCII;
            HashAlgorithm algorithm = MD5.Create();

            Console.Write("Enter a string to hash to MD5: ");
            string input = Console.ReadLine();
            byte[] inputBytes = encoding.GetBytes(input);
            string output = BitConverter.ToString(algorithm.ComputeHash(inputBytes));

            Console.WriteLine($"output - {output}");
            Console.WriteLine($"output (no dashes) - {output.Replace("-", "")}\n");

            algorithm = SHA1.Create();
            Console.Write("Enter a string to hash to SHA1: ");
            input = Console.ReadLine();
            inputBytes = encoding.GetBytes(input);
            output = BitConverter.ToString(algorithm.ComputeHash(inputBytes));

            Console.WriteLine($"output - {output}");
            Console.WriteLine($"output (no dashes) - {output.Replace("-", "")}");
        }
    }
}