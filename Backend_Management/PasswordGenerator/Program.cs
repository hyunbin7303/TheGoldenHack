using Backend_Management.Models;
using System;
using System.Text;

namespace PasswordGenerator
{
    class Program
    {
        private static string temp_pass = "kevinPark";
        static void Main(string[] args)
        {
            var test = Convert.ToBase64String(Hashing.GetRandomSalt(16));
            Console.WriteLine(test);
            //var test2 = Hashing.SaltHashPassword()
            var test2 = Convert.ToBase64String(Hashing.SaltHashPassword(
                    Encoding.ASCII.GetBytes(temp_pass),
                    Convert.FromBase64String(test)));
            Console.WriteLine(test2);

             var client_post_hash_password = Convert.ToBase64String(
                    Hashing.SaltHashPassword(Encoding.ASCII.GetBytes(temp_pass),
                                            Convert.FromBase64String(test)));
            Console.WriteLine(client_post_hash_password);

        }
    }
}
