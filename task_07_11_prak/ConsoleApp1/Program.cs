using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        public delegate int customDelegate(int x1, int x2);
        static void Main(string[] args)
        {
            customDelegate custom = new customDelegate(Subtract);
            
            Console.WriteLine(custom(4,5));

        }
        public static int Sum(int x1, int x2)
        {
            return x1 + x2;
        }
        public static int Subtract(int x1, int x2)
        {
            return x1 - x2;
        }
        public static int Multiply(int x1, int x2)
        {
            return x1 * x2;
        }
    }
}
