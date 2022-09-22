using System;

namespace _04._Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string reversed = String.Join("", text.Reverse());
            Console.WriteLine(reversed);
        }
    }
}
