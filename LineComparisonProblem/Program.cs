using System;
namespace LineComparisonProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to line Comparison Problem statement");
            CalculateLength length = new CalculateLength(1,2,3,4);
            length.Calculate();
        }
    }
}