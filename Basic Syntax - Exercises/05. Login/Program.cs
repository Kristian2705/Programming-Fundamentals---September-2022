using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            char currL = ' ';
            bool k = false;
            for (int i = username.Length - 1; i >= 0; i--)
            {
                currL = username[i];
                password += currL;
            }
            int counter = 1;
            string input = Console.ReadLine();
            while (input != password)
            {
                if (counter == 4)
                {
                    k = true;
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                counter++;
                input = Console.ReadLine();
            }
            if (k)
            {
                Console.WriteLine($"User {username} blocked!");
            }
            else
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
