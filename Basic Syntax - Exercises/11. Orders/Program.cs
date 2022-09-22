using System;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double totalPrice = 0.0;
            for (int i = 1; i <= n; i++)
            {
                double capsulePrice = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsules = int.Parse(Console.ReadLine());
                double currentPrice = (days * capsules) * capsulePrice;
                totalPrice += currentPrice;
                Console.WriteLine($"The price for the coffee is: ${currentPrice:F2}");
            }
            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
