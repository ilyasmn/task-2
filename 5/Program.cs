using System;

namespace _5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 66666;

            int c = int.Parse(4 + a.ToString() + 44);

            double b = c * 44 * 1.0 / 100;

            Console.WriteLine(b);
        }
    }
}
