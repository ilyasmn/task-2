using System;

namespace _7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 66666;
            int b = 55555;

            int c = a + b;

            int d = int.Parse(5 + c.ToString() + 5);

            double e = d * 5 * 1.0 / 100;
            Console.WriteLine(e);
        }
    }
}
