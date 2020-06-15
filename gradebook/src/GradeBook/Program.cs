using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("King");
            book1.Add(9.9);
            book1.Add(3.4);


            double[] numbers = new [] {3.4, 1.4, 9.5};
            var grades = new List<double>() {3.4, 1.4, 9.5, 8.3};
            var results = 0.0;
            foreach(var grade in grades)
            {
                double total;
                total += grade;
                results = total / grades.count();
            }

            if(args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]}!");
            }

            else
            {
                Console.WriteLine("Hello!");
                Console.WriteLine(results);
            }
        }
    }
}
