using System;

namespace _14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 10000, 20000, 30000, 40000, 50000, 60000 };
            int uzunluq = a.Length;
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            { sum = sum + a[i]; }
            Console.WriteLine(sum);
            {
                int c = int.Parse(a[0].ToString() + a[2].ToString());
                Console.WriteLine(c);
                int v = sum - c;
                Console.WriteLine(v);
                int f = v / 10;
                Console.WriteLine(f);
                int g = f + a[4] + a[5];
                Console.WriteLine(g);
                int h = g * 11 / 100;

                Console.WriteLine(h);
            }
            }
    }
}
