using Core.Models;

namespace ConsoleApp1;

public static class Authorization
{
    public static void Register(string name, string surname, string username, string password)
    {
        User user = new User();
        user.Name = name;
        user.Surname = surname;
        user.Username = username;
        user.Password = password;
        Program.users.Add(user);
        Console.WriteLine("Register olundu");
    }

    public static void Login(string username, string password)
    {
        foreach (var item in Program.users)
        {
            if (item.Username == username && item.Password == password)
            {
                Console.WriteLine("Login olundu!");
                Program.LogedIn = item;
                return;
            }
        }
        Console.WriteLine("bele user yoxdu");
    }
    public static void GetUsers()
    {
        foreach (var item in Program.users)
        {
            Console.WriteLine(item.Username);
        }
    }

    public static void Logout() 
    {
        Program.LogedIn = null;
    }
}
