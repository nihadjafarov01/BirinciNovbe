namespace CustomStringMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IndexOf("salam",'a');
            LastIndexOf("salam", 'a');
                   
            static void IndexOf(string salam ,char character)
            {
                int indexOf = 0;
                for (int i = 0; i < salam.Length; i++)
                {
                    if (salam[i] == character)
                    {
                        indexOf = i;
                        break;
                    }
                }
                Console.WriteLine(indexOf);
            }

            static void LastIndexOf(string salam, char character)
            {
                int lastIndexOf = 0;
                for (int i = salam.Length - 1; i >= 0; i--)
                {
                    if (salam[i] == character)
                    {
                        lastIndexOf = i;
                        break;
                    }
                }
                Console.WriteLine(lastIndexOf);
            }

        }

    }
}