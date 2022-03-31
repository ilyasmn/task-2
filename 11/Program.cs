using System;

namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1000, 2000, 3000, 4000 };
            int length = a.Length;


            int b = a[0] + a[2];
            int c = a[1] + a[3];

            int d = b * c;

            double e = 3 * 1.0 * a[2] / 100;

            double f = d - e;
            Console.WriteLine(f);
        }
    }
}
