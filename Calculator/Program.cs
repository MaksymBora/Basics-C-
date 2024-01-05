namespace Calculator;

internal class Program
{
    private static void Main(string[] args)
    {
        // -------------------- Option 1 --------------------------- //
        // double firstValue, secondValue, result;
        //
        //
        // Console.WriteLine("Please enter value 1! ");
        // firstValue = double.Parse(Console.ReadLine());
        //
        // Console.WriteLine("Please enter value 2! ");
        // secondValue = double.Parse(Console.ReadLine());
        //
        // Console.WriteLine("Please enter '+', '-', '*', '/' ! ");
        // // ConsoleKey consoleKey = Console.ReadKey().Key;
        // ConsoleKeyInfo keyInfo = Console.ReadKey();
        // char input = keyInfo.KeyChar;
        //
        //
        // switch (input)
        // {
        //     case '+':
        //         result = firstValue + secondValue;
        //         Console.WriteLine("The result is >>> " + result);
        //         break;
        //     case '-':
        //          result = firstValue - secondValue;
        //         Console.WriteLine("The result is >>> " + result);
        //         break;
        //     case '/':
        //          result = firstValue / secondValue;
        //         Console.WriteLine("The result is >>> " + result);
        //         break;
        //     case '*':
        //         result = firstValue * secondValue;
        //         Console.WriteLine("The result is >>> " + result);
        //         break;
        //     default:
        //         Console.WriteLine("Unknown operation!");
        //         break;
        // }

        // ---------------------------- Option 2 --------------------- //

        // double firstValue, secondValue, result;
        //
        // Console.WriteLine("Please enter value 1! ");
        // firstValue = double.Parse(Console.ReadLine());
        //
        // Console.WriteLine("Please enter value 2! ");
        // secondValue = double.Parse(Console.ReadLine());
        //
        // Console.WriteLine("Please enter '+', '-', '*', '/' ! ");
        // ConsoleKeyInfo keyInfo = Console.ReadKey();
        // char input = keyInfo.KeyChar;
        //
        // if (input == '+')
        // {
        //     result = firstValue + secondValue;
        //     Console.WriteLine("The result is >>> " + result);
        // } else if (input == '-')
        // {
        //     result = firstValue - secondValue;
        //     Console.WriteLine("The result is >>> " + result);
        // } else if (input == '*')
        // {
        //     result = firstValue * secondValue;
        //     Console.WriteLine("The result is >>> " + result);
        // } else if (input == '/') 
        // {
        // if (secondValue == 0)
        //     Console.WriteLine(0);
        // else
        // {
        //     result = firstValue / secondValue;
        //     Console.WriteLine("The result is >>> " + result);
        // }
        //
        // }


        // ---------------------------- Option 3 --------------------- //

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
            var action = Console.ReadLine();


            switch (action)
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