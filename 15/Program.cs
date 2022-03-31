using System;

namespace _15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 100, 200, 3000, 4000, 50000, 60000, 100000 };

            int b = a[0] + a[1];
            int c = a[2] * a[3];
            int d = b + c;
            int e = int.Parse(d.ToString() + 7);
            int f = e + a[4] + a[5];
            int g = a[0] * a[1];
            int h = int.Parse(g.ToString() + 1);
            int i = f - h;
            int j = i + a[6];
            int k = a[0] + a[1] + a[2] + a[3];
            int l = j - k;
            double m = l * 0.18 * 0.03 * 0.01 * 1.0;
            double n = m + a[4] + a[5];
            Console.WriteLine(n);
        }
    }
}
