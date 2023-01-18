using System;

namespace AmstrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0, rev,temp;
            Console.WriteLine("enter the number");
            int num =Convert.ToInt32(Console.ReadLine());
            temp = num;
            while(num > 0)
            {
                rev = num % 10;
                sum = sum + (rev * rev * rev);
                num = num / 10;
            }
            if(sum == temp)
            {
                Console.WriteLine("number is amstrong");
            }
            else
            {
                Console.WriteLine("number is not amstrong");

            }
        }
    }
}
