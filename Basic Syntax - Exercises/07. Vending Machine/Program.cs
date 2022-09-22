using System;

namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double balance = 0.0;
            while (input != "Start")
            {
                double coins = double.Parse(input);
                if (coins == 0.1 || coins == 0.2 || coins == 0.5 || coins == 1 || coins == 2)
                {
                    balance += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                input = Console.ReadLine();
            }
            string product = Console.ReadLine();
            double totalPrice = 0.0;
            while (product != "End")
            {
                if (product == "Nuts")
                {
                    totalPrice = 2;
                    if (balance >= totalPrice)
                    {
                        Console.WriteLine($"Purchased nuts");
                        balance -= totalPrice;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Water")
                {
                    totalPrice = 0.7;
                    if (balance >= totalPrice)
                    {
                        Console.WriteLine($"Purchased water");
                        balance -= totalPrice;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Crisps")
                {
                    totalPrice = 1.5;
                    if (balance >= totalPrice)
                    {
                        Console.WriteLine($"Purchased crisps");
                        balance -= totalPrice;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Soda")
                {
                    totalPrice = 0.8;
                    if (balance >= totalPrice)
                    {
                        Console.WriteLine($"Purchased soda");
                        balance -= totalPrice;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else if (product == "Coke")
                {
                    totalPrice = 1;
                    if (balance >= totalPrice)
                    {
                        Console.WriteLine($"Purchased coke");
                        balance -= totalPrice;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                product = Console.ReadLine();
            }
            Console.WriteLine($"Change: {balance:F2}");
        }
    }
}
