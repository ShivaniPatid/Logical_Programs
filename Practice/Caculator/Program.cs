using System;

namespace Caculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                int res;
                Console.WriteLine("Enter the first number");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number");
                int n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the any +,-,*,/ symbol");
                string operation = Console.ReadLine();
                switch (operation)
                {
                    case "+":
                        res = n1 + n2;
                        Console.WriteLine("n1 + n2 = " + res);
                        break;
                    case "-":
                        res = n1 - n2;
                        Console.WriteLine("n1 - n2 =  " + res);
                        break;
                    case "*":
                        res = n1 * n2;
                        Console.WriteLine("n1 * n2 = " + res);
                        break;
                    case "/":
                        res = n1 / n2;
                        Console.WriteLine("n1 / n2 = " + res);
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
                Console.Write("Do you want to continue(y/n):");
                value = Console.ReadLine();

            }
            while (value == "y" || value == "Y");
            



        }
    }
}
