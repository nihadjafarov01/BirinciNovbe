namespace ConsoleApp1;

internal static class Extension
{
    public static bool customContains(this string sentence ,string key)
    {
        string temp = "";
        string temp2 = "";
        int index = 0;
        sentence = sentence.ToLower();
        key =  key.ToLower();
        if (temp != key)
        {
            for (int i = 0; i < sentence.Length; i++)
            {
                index = i;
                for (int j = 0; j < key.Length; j++)
                {
                    if (key[j] == sentence[index])
                    {
                        temp = temp + key[j];
                        index++;
                    }
                    else
                    {
                        temp = "";
                        j = key.Length - 1;
                    }
                }
                if (temp == key)
                {
                    Console.WriteLine("true");
                    return true;
                }
            }
        }

        if (temp == key)
        {
            Console.WriteLine("true");
            return true;
        }
        else
        {
            Console.WriteLine("false");
            return false;
        }
    }
}
