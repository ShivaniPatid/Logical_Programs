using System;

namespace PercentageHeadsTails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int h_count = 0, t_count = 0;
            double heads, tails;
            Console.WriteLine("Enter number you want to flip the coin");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                for (int i = 0; i < number; i++)
                {


                    Random random = new Random();
                    double randomnum = random.NextDouble();
                    if (randomnum > 0.5)
                    {
                        Console.WriteLine("head");
                        h_count++;
                    }
                    else
                    {
                        Console.WriteLine("tail");
                        t_count++;
                    }
                }
                heads = h_count * 100 / number;
                tails = t_count * 100 / number;

                Console.WriteLine("Percentage of head : " + heads + "%");
                Console.WriteLine("Percentage of tail : " + tails + "%");
            }
            else
            {
                Console.WriteLine("number must be greater thena zero");
            }
        }
    }
}
