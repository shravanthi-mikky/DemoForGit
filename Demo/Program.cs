using System;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            uc1_Addition uc1 = new uc1_Addition();
            int c = uc1.Addition(2, 3);
            Console.WriteLine(c);
        }
    }
}
