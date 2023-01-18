using System;

namespace PowerOfN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the range");
            int range = Convert.ToInt32(Console.ReadLine());

            if(range < 0 || range > 32)
            {
                Console.WriteLine("Please enter number between o to 31");

            }
            else
            {
                for( int i = 0; i < range; i++)
                {
                    Console.WriteLine("power of "+i+" = "+(int)Math.Pow(i, 2));
                }
            }
        }
    }
}
