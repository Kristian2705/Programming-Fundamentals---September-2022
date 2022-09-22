using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string group = Console.ReadLine();
            string day = Console.ReadLine();
            double totalPrice = 0.0;
            if (group == "Students")
            {
                switch (day)
                {
                    case "Friday":
                        totalPrice = people * 8.45;
                        break;
                    case "Saturday":
                        totalPrice = people * 9.8;
                        break;
                    case "Sunday":
                        totalPrice = people * 10.46;
                        break;
                }
                if (people >= 30)
                {
                    totalPrice *= 0.85;
                }
            }
            else if (group == "Business")
            {
                switch (day)
                {
                    case "Friday":
                        totalPrice = people * 10.9;
                        break;
                    case "Saturday":
                        totalPrice = people * 15.6;
                        break;
                    case "Sunday":
                        totalPrice = people * 16;
                        break;
                }
                if (people >= 100)
                {
                    switch (day)
                    {
                        case "Friday":
                            totalPrice = (people - 10) * 10.9;
                            break;
                        case "Saturday":
                            totalPrice = (people - 10) * 15.6;
                            break;
                        case "Sunday":
                            totalPrice = (people - 10) * 16;
                            break;
                    }
                }
            }
            else if (group == "Regular")
            {
                switch (day)
                {
                    case "Friday":
                        totalPrice = people * 15;
                        break;
                    case "Saturday":
                        totalPrice = people * 20;
                        break;
                    case "Sunday":
                        totalPrice = people * 22.5;
                        break;
                }
                if (people >= 10 && people <= 20)
                {
                    totalPrice *= 0.95;
                }
            }
            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
