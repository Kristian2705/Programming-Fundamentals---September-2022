using System;

namespace _08._Triangle_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 1; i <= n; i++)
            {
                counter = i;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(counter + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
