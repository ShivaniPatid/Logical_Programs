using System;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, fact = 1;
            Console.WriteLine("enter the number");
            int num = Convert.ToInt32(Console.ReadLine());  
            for(i = 0;i<num;i++)
            {
                fact += fact*i;
            }
            Console.WriteLine("result is : "+fact);
        }
    }
}
