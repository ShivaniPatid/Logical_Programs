using System;

namespace PerfectNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, rem, sum = 0, i;
            Console.WriteLine("Enter the number");
            num = Convert.ToInt32(Console.ReadLine());

            for(i = 1; i < num; i++)
            {
                rem = num % i;
                if(rem == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == num)
            {
                Console.WriteLine(num + " is perfect number");
            }
            else
            {
                Console.WriteLine(num + " is not perfect number");

            }
        }
    }
}
