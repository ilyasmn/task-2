using System;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 6666;

            int b = 7;
            int c = 8;

            int d = int.Parse(b.ToString() + a.ToString() + c.ToString());


            Console.WriteLine(d);
        }
    }
}
