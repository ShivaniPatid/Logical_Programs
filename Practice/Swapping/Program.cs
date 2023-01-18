using System;

namespace Swapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c;
            Console.WriteLine("enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("use of third variable");
            c = a;
            a = b;
            b = c;
            Console.WriteLine("a = "+a);
            Console.WriteLine("b = " + b);
            Console.WriteLine();
            Console.WriteLine("enter the number");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the number");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("use of third variable");
            Console.WriteLine("without use of third variable");
            x = x + y; //10+20 = 30
            y = x - y; //30-20 =10
            x = x - y; //30-10=20
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
        }
    }
}
