using System;

namespace _04._Back_In_30_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int totalNewMinutes = hours * 60 + minutes + 30;
            if (totalNewMinutes / 60 == 24)
            {
                Console.WriteLine($"0:{totalNewMinutes % 60:D2}");
            }
            else
            {
                Console.WriteLine($"{totalNewMinutes / 60}:{totalNewMinutes % 60:D2}");
            }
        }
    }
}
