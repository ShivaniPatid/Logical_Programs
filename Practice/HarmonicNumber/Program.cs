using System;

namespace HarmonicNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = 0;
            Console.WriteLine("enter a harmonic you want to find");
            int n = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.Write("1 / {0} + ",i);
                num += (1 / (double)i);
            }
            Console.WriteLine();
            Console.WriteLine("harmonic value {0} is : {1}", n, num);
        }
    }
}
