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
            if (length1.Equals(length2))
                Console.WriteLine("Both the lines are equal");
            else
                Console.WriteLine("Both the lines are not equal");
        }
    }
}