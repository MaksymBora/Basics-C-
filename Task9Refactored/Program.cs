using System;

namespace Task9Refactored
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator(); 

            Console.WriteLine("Enter expression:");
            string input = Console.ReadLine();

            try
            {
                double result = calculator.CalculateExpression(input);
                Console.WriteLine($"Result is: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}