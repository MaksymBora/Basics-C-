using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                double firstValue, secondValue, result;

                try
                {
                    Console.WriteLine("Please enter value 1! ");
                    firstValue = double.Parse(Console.ReadLine());

                    Console.WriteLine("Please enter value 2! ");
                    secondValue = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Error! Unknown type of numbers!");

                    Console.WriteLine("Press Enter to continue or press CTRL+C to stop the Program! ");
                    Console.ReadLine();

                    continue;
                }

                Console.WriteLine("Please enter '+', '-', '*', '/' ! ");
                var firstAction = Console.ReadLine();


                switch (firstAction)
                {
                    case "+":
                        result = firstValue + secondValue;
                        Console.WriteLine("The result is >>> " + result);
                        break;
                    case "-":
                        result = firstValue - secondValue;
                        Console.WriteLine("The result is >>> " + result);
                        break;
                    case "/":
                        if (secondValue == 0)
                        {
                            Console.WriteLine(0);
                        }
                        else
                        {
                            result = firstValue / secondValue;
                            Console.WriteLine("The result is >>> " + result);
                        }

                        break;
                    case "*":
                        result = firstValue * secondValue;
                        Console.WriteLine("The result is >>> " + result);
                        break;
                    default:
                        Console.WriteLine("Unknown operation!");
                        break;
                }

                Console.WriteLine("Press Enter to continue or press CTRL+C to stop the Program! ");
                Console.ReadLine();
            }
        }
    }
}