using System;

namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = n;
            int num1 = 0;
            int mult = 1;
            int sum = 0;
            while (num != 0)
            {
                num1 = num % 10;
                for (int i = num1; i >= 1; i--)
                {
                    mult *= i;
                }
                sum += mult;
                mult = 1;
                num /= 10;
            }
            if (n == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
