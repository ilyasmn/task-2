using System;

namespace _8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4444;
            int b = 7777777;

            double c = a * 4 * 1.0 / 100;
            double d = b * 9 * 1.0 / 100;

            double e = (c + d) * 1.0 / 10;

            Console.WriteLine(e);
        }
    }
}
