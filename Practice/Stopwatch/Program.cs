using System;

namespace Stopwatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);   
            }
            watch.Stop();
            Console.WriteLine($"Execution time : {watch.ElapsedMilliseconds} ms");
        }
    }
}
