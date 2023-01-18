using System;

namespace ReversePalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int sum = 0, r;
            while(num > 0)
            {
                r = num % 10;
                sum = sum * 10 + r;
                num  /= 10;
            }
            Console.WriteLine("Reverse number is : " + sum);

            if(temp == sum)
            {
                Console.WriteLine(sum+" number is palindorme");
            }
            else
            {
                Console.WriteLine(sum+" number is not palindorme");

            }
        }
    }
}
