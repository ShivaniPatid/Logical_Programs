using System;

namespace PrimeSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int isPrime=0, i, j;
            for (i = 0; i <= 100; i++)
            {
                if(i == 0||i==1)
                
                    continue;
                
                isPrime = 0;
                for (j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = 1;
                        break;
                    }
                }
                if(isPrime==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
