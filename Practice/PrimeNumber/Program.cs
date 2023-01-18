using System;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int isPrime = 0;
            Console.WriteLine("check number is prime or not");
            int n = Convert.ToInt32(Console.ReadLine());

            if(n==0||n==1)
            {
                isPrime = 1;
            }
            for(int i =2;i<=n/2;i++)
            {
                if(n%i==0)
                {
                    isPrime = 1;
                    break;
                }
            }
            if (isPrime == 0)
            {
                Console.WriteLine(n + " number is prime");
            }
            else
            {
                Console.WriteLine(n + " number is not prime");

            }
        }
    }
}
