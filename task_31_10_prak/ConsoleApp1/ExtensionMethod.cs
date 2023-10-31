namespace ConsoleApp1;

public static class ExtensionMethod
{
    public static bool CustomContains(this string value, char c)
    {
        for (int i = 0; i < value.Length; i++)
        {
            if (value[i] == c)
            {
                return true;
            }
        }
        return false;
    }
}
