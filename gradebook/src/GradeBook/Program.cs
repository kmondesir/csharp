using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new [] {3.4, 1.4, 9.5};
            var results = 0.0;
            foreach(double number in numbers)
            {
                results += number;
            }

            if(args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]}");
            }
            else
            {
                Console.WriteLine("Hello!");
                Console.WriteLine(results);
            }
        }
    }
}
