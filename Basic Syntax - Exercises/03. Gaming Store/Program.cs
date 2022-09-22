using System;

namespace _03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double gamePrice = 0.0;
            double spentMoney = 0.0;
            string currentGame = string.Empty;
            while (input != "Game Time")
            {
                currentGame = input;
                if (input == "OutFall 4")
                {
                    gamePrice = 39.99;
                }
                else if (input == "CS: OG")
                {
                    gamePrice = 15.99;
                }
                else if (input == "Zplinter Zell")
                {
                    gamePrice = 19.99;
                }
                else if (input == "Honored 2")
                {
                    gamePrice = 59.99;
                }
                else if (input == "RoverWatch")
                {
                    gamePrice = 29.99;
                }
                else if (input == "RoverWatch Origins Edition")
                {
                    gamePrice = 39.99;
                }
                else
                {
                    Console.WriteLine("Not Found");
                    input = Console.ReadLine();
                    continue;
                }
                if (balance >= gamePrice)
                {
                    balance -= gamePrice;
                    spentMoney += gamePrice;
                    Console.WriteLine($"Bought {currentGame}");
                    if (balance == 0)
                    {
                        Console.WriteLine("Out of money!");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${spentMoney:F2}. Remaining: ${balance:F2}");
        }
    }
}
