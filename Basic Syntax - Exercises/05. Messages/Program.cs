using System;

namespace _05._Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numbers = 0;
            int num = 0;
            int mainDigit = 0;
            int digitCounter = 0;
            int offset = 0;
            int letterIndex = 0;
            string word = string.Empty;
            int currentLetter = 97;
            for (int i = 1; i <= n; i++)
            {
                numbers = int.Parse(Console.ReadLine());
                if (numbers == 0)
                {
                    word += " ";
                    continue;
                }
                else if (numbers == 1)
                {
                    continue;
                }
                num = numbers;
                while (num != 0)
                {
                    mainDigit = num % 10;
                    num /= 10;
                    digitCounter++;
                }
                if (mainDigit == 8 || mainDigit == 9)
                {
                    offset = (mainDigit - 2) * 3 + 1;
                }
                else
                {
                    offset = (mainDigit - 2) * 3;
                }
                letterIndex = offset + digitCounter - 1;
                currentLetter += letterIndex;
                char character = (char)currentLetter;
                word += character;
                digitCounter = 0;
                currentLetter = 97;
            }
            Console.WriteLine(word);
        }
    }
}
