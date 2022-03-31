using System;

namespace _9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 444444;
            int b = 777777;
            int c = 888888;

            double aa = a * 10 * 1.0 / 100;
            double bb = b * 10 * 1.0 / 100;
            double cc = c * 10 * 1.0 / 100;

            double e = aa + bb + cc;

            double f = e * 1.0 / 10;

            Console.WriteLine(f);
        }
    }
}
