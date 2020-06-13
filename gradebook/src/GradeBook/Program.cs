using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 4.5;
            double y = 5.3;
            double result = x + y;

            if(args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]}");
            }
            else
            {
                Console.WriteLine("Hello!");
                Console.WriteLine(x+y);
            }
        }
    }
}
