using System;

namespace _10._Rage_Expenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());
            int headsetC = 0;
            int mouseC = 0;
            int keyboardC = 0;
            int displayC = 0;
            for (int i = 1; i <= lostGames; i++)
            {
                if (i % 2 == 0)
                {
                    headsetC++;
                }
                if (i % 3 == 0)
                {
                    mouseC++;
                }
                if (i % 6 == 0)
                {
                    keyboardC++;
                }
                if (i % 12 == 0)
                {
                    displayC++;
                }
            }
            double totalExpenses = headsetC * headsetPrice + mouseC * mousePrice + keyboardC * keyboardPrice + displayC * displayPrice;
            Console.WriteLine($"Rage expenses: {totalExpenses:F2} lv.");
        }
    }
}
