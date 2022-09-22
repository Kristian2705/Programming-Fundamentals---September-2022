using System;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int belts = students;
            int freeBelts = 0;
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());
            double lightsabersTotal = Math.Ceiling((students + students * (10 / 100.0))) * lightsaberPrice;
            double robesTotal = students * robePrice;
            freeBelts = students / 6;
            belts -= freeBelts;
            double beltsTotal = belts * beltPrice;
            double totalSum = lightsabersTotal + robesTotal + beltsTotal;
            if (totalSum <= balance)
            {
                Console.WriteLine($"The money is enough - it would cost {totalSum:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalSum - balance:F2}lv more.");
            }
        }
    }
}
