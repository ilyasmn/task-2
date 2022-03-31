using System;

namespace _4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 666;

            int b = int.Parse(a.ToString() + 7);

            double c = b * 7 * 1.0 / 100;

            Console.WriteLine(c);
        }
    }
}
