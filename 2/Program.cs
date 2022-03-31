using System;

namespace _2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 666;

            int b = int.Parse(a.ToString() + a.ToString());
            Console.WriteLine(b);
        }
    }
}
