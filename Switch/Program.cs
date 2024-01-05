using System;

namespace Switch;

internal class Program
{
    private static void Main(string[] args)
    {
        // int a = int.Parse(Console.ReadLine());

        // switch (a)
        // {
        //     case 1:
        //         Console.WriteLine("You entered 1");
        //         break;
        //     
        //     case 2:
        //         Console.WriteLine("You entered 2");
        //         break;
        //     default:
        //
        //         Console.WriteLine("I don't know what to do with this number!");
        //         break;
        //     
        // }

        // switch (a)
        // {
        //     case 1:
        //     case 2:
        //         Console.WriteLine("You entered number 1 or number 2");
        //         break;
        //     default:
        //
        //         Console.WriteLine("I don't know what to do with this number!");
        //         break;
        //     
        // }

        // string a = Console.ReadLine();
        //
        // switch (a)
        // {
        //     case "+":
        //         Console.WriteLine("You entered plus ");
        //         break;
        //     case "-":
        //         Console.WriteLine("You entered minus ");
        //         break;
        //     default:
        //         Console.WriteLine("You entered unknown symbol");
        //         break;
        //     
        // }

        // ----------------------------- Console Keys ---------------------- //

        var consoleKey = Console.ReadKey().Key;

        switch (consoleKey)
        {
            case ConsoleKey.Backspace:
                Console.WriteLine("You pressed backspace! ");
                break;
            default:
                Console.WriteLine("Unknown button!");
                break;
        }
    }
}