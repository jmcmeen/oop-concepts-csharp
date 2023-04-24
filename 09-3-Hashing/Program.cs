using System.Security.Cryptography;
using System.Text;

namespace _09_03_Hashing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashAlgorithm algorithm = MD5.Create();
            Console.Write("Enter a string to hash to MD5: ");
            string input = Console.ReadLine();
            byte[] inputBytes = Encoding.ASCII.GetBytes(input);
            string output = BitConverter.ToString(algorithm.ComputeHash(inputBytes));

            Console.WriteLine($"output - {output}");
            Console.WriteLine($"output (no dashes) - {output.Replace("-","")}\n");


            algorithm = SHA1.Create();
            Console.Write("Enter a string to hash to SHA1: ");
            input = Console.ReadLine();
            inputBytes = Encoding.ASCII.GetBytes(input);
            output = BitConverter.ToString(algorithm.ComputeHash(inputBytes));

            Console.WriteLine($"output - {output}");
            Console.WriteLine($"output (no dashes) - {output.Replace("-", "")}");
        }
    }
}