using Core.Models;
using System.Reflection.Metadata;

namespace ConsoleApp1;

public class Program
{
    public static List<User> users = new List<User>();
    public static User LogedIn 
    { 
        get; 
        set; 
    }
    static void Main(string[] args)
    { 
        char option = '0' ;
        while (option != 'q')
        {
            if (LogedIn == null)
            {
                Console.WriteLine("1 -> Login \n2 -> Register \n3 -> GetUsers \nq -> quit");
                option = Convert.ToChar(Console.ReadLine());
                switch (option)
                {
                    case '1':
                        Console.WriteLine("Username: ");
                        string username1 = Console.ReadLine();
                        Console.WriteLine("Password: ");
                        string password1 = Console.ReadLine();
                        Authorization.Login(username1, password1);
                        break;
                    case '2':
                        Console.WriteLine("Name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Surname: ");
                        string surname = Console.ReadLine();
                        Console.WriteLine("Username: ");
                        string username = Console.ReadLine();
                        Console.WriteLine("Password: ");
                        string password = Console.ReadLine();
                        Authorization.Register(name, surname, username, password);
                        break;
                    case '3':
                        Authorization.GetUsers();
                        break;
                }
            }
            else
            {
                Console.WriteLine("1 -> Logout \nq -> quit");
                option = Convert.ToChar(Console.ReadLine());
                switch (option)
                {
                    case '1':
                        Authorization.Logout();
                        break;
                }
            }
            
        }
    }
}