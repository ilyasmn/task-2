using System;

namespace _12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 100000, 200000, 300000, 400000 };
            int sum = 0;

            for (int i = 0; i < a.Length; i++)

            { sum = sum + a[i]; }


            double b = 1.0 * sum / 10;
            double c = 1.0 * sum * 15 / 100;
            double d = b * c;
            double e = d * 0.1 * 0.11;
            Console.WriteLine(e);
        }
    }
}
