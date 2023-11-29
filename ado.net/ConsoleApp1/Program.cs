using ConsoleApp1.Models;
using ConsoleApp1.Services;
using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        public static System.String sha256_hash(System.String value)
        {
            StringBuilder Sb = new StringBuilder();

            using (SHA256 hash = SHA256Managed.Create())
            {
                Encoding enc = Encoding.UTF8;
                Byte[] result = hash.ComputeHash(enc.GetBytes(value));

                foreach (Byte b in result)
                    Sb.Append(b.ToString("x2"));
            }

            return Sb.ToString();
        }
        static void Main(string[] args)
        {
            while (true)
            {
            string Password = Console.ReadLine();
            string hashed = sha256_hash(Password);
                Console.WriteLine(hashed);
            }
        
        }
    }
}
