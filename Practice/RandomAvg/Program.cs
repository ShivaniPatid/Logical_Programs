using System;

namespace RandomAvg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, avg, number;
            Console.WriteLine("enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < num; i++)
            {
                Random random = new Random();
                number =  random.Next(10,50);
                Console.WriteLine(number);
                sum += number;
            }
            avg = sum / num;
            Console.WriteLine("Avg : " + avg);
        }
    }
}
