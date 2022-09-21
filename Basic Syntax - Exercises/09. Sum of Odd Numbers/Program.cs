using System;

namespace _09._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int i = 1;
            int num = 1;
            int sum = 0;
            while (i <= n)
            {
                Console.WriteLine(num);
                sum += num;
                num += 2;
                i++;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
