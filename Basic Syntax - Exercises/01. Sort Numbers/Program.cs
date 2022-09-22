using System;

namespace _01._Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double l = double.Parse(Console.ReadLine());
            double max = 0, min = 0, mid = 0;
            if (n == m && n == l && m == l)
            {
                max = n;
                mid = m;
                min = l;
            }
            if ((n >= m && m >= l) || (n >= l && l >= m))
            {
                max = n;
            }
            else if ((m >= n && n >= l) || (m >= l && l >= n))
            {
                max = m;
            }
            else if ((l >= n && n >= m) || (l >= m && m >= n))
            {
                max = l;
            }
            if ((n <= m && m <= l) || (n <= l && l <= m))
            {
                min = n;
            }
            else if ((m <= n && n <= l) || (m <= l && l <= n))
            {
                min = m;
            }
            else
            {
                min = l;
            }
            if ((max == m && min == l) || (max == l && min == m))
            {
                mid = n;
            }
            else if ((max == n && min == l) || (max == l && min == n))
            {
                mid = m;
            }
            else
            {
                mid = l;
            }
            Console.WriteLine(max);
            Console.WriteLine(mid);
            Console.WriteLine(min);
        }
    }
}
