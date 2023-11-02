using ConsoleApp1.Exceptions;
using ConsoleApp1.Models;
using System.Numerics;
using System.Text.RegularExpressions;

namespace ConsoleApp1;

internal class Program
{

    static void Main(string[] args)
    {
        string name;
        byte age;
        string password;
        string phoneNumber;
        char option = '0';
        User user = new User();
        do
        {
            //option = Convert.ToChar(Console.ReadLine());
            try
            {
                Console.WriteLine("Enter name: ");
                name = Console.ReadLine();
                user.Name = name;
                if (user.Name == name)
                {
                    age:
                    Console.WriteLine("Enter age: ");
                    age = Convert.ToByte(Console.ReadLine());
                    user.Age = age;
                    if (user.Age == age)
                    {
                        Console.WriteLine("Enter phone number: ");
                        phoneNumber = Console.ReadLine();
                        user.PhoneNumber = phoneNumber;
                        if (user.PhoneNumber == phoneNumber)
                        {
                            Console.WriteLine("Enter password: ");
                            password = Console.ReadLine();
                            user.Password = password;
                        }
                    }
                }
            }
            catch (InvalidNameException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidAgeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidPhoneFormat ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (InvalidPasswordException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        while (option != 'q');

    }
}
