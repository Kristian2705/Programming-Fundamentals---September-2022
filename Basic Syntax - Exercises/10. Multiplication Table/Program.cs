using System;

namespace _10._Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine($"{n} X {j} = {n * j}");
            }
        }
    }
}
