using List.Models;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntList list = new IntList();
            list.Add(3);
            list.Get(0);
            list.Print();
            
        }
    }
}
