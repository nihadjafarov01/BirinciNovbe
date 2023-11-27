using System.Security.Cryptography;
using ConsoleApp1.Helpers;
using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1.Services
{
    public class UserService
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
        public void Register(User user)
        {
            string hashed = sha256_hash(user.Password);
            string query = $"INSERT INTO Blogs VALUES (N'{user.Name}', N'{user.Surname}', {user.Password}";
            SqlHelper.Exec(query);
        }
    }
}
