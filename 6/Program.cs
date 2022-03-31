using System;

namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1000;

            double b = a * 20 * 1.0 / 100;
            double c = b * 10 * 1.0 / 100;

            double d = Math.Pow(c, 2);

            Console.WriteLine(d);
        }
    }
}
