using System;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 4444;
            int b = 7777;
            int c = 8888;

            double aa = a * 1 * 1.0 / 100;
            double bb = b * 2 * 1.0 / 100;
            double cc = c * 3 * 1.0 / 100;



            double e = aa - bb - cc;

            double f = e + c * 3 * 1.0 / 100;

            Console.WriteLine(f);
        }
    }
}
