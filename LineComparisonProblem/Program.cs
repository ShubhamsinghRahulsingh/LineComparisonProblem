using System;
namespace LineComparisonProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line Comparison Problem statement");
            CalculateLength calculate1 = new CalculateLength(1,2,3,4);
            double length1 = calculate1.Calculate();
            CalculateLength calculate2 = new CalculateLength(1, 2, 3, 4);
            double length2 = calculate2.Calculate();
            if(length1.CompareTo(length2) == 0)
                Console.WriteLine("Line 1 is equal to Line 2");
            else if (length1.CompareTo(length2) > 0)
                Console.WriteLine("Line 1 is greater than Line 2");
            else
                Console.WriteLine("Line 1 is less than Line 2");
        }
    }
}