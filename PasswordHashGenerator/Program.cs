// See https://aka.ms/new-console-template for more information
// filepath: PasswordHashGenerator/Program.cs
using System;
using System.Security.Cryptography;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter password to hash: ");
        string password = Console.ReadLine();

        using var hmac = new HMACSHA512();
        byte[] passwordSalt = hmac.Key;
        byte[] passwordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

        Console.WriteLine("Hash: " + Convert.ToBase64String(passwordHash));
        Console.WriteLine("Salt: " + Convert.ToBase64String(passwordSalt));
    }
}
