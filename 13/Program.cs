using System;

namespace _13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] eded = { 10000, 20000, 30000, 400, 500 };

            int uzunluq = eded.Length;

            double hasil = 1;
            double sum = 0;
            for (int i = 0; i < uzunluq; i++)
            {
                if (eded[i] >= 10000)
                {
                    double faiz = 5 * 1.0 * eded[i] / 100;
                    hasil = faiz * hasil;

                    Console.WriteLine(hasil);
                    continue;
                }
                else
                {
                    double faiz = 3 * 1.0 * eded[i] / 100;
                    sum = faiz + sum;
                }
                Console.WriteLine(sum);
            }
            double x = sum * 1.0 / 10;
            double y = hasil * 1.0 / 10;
            double z = x + y;
            Console.WriteLine(z);
        }
    }
}
