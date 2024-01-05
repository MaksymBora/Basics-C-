using System.Globalization;

namespace Lesson;

internal class Program
{
    private static void Main(string[] args)
    {
        // string str;
        //
        // int a, b;
        //
        // Console.WriteLine("Enter a figure 1");
        // str = Console.ReadLine();
        //
        // a = Convert.ToInt32(str);
        //
        // Console.WriteLine("Enter a figure 2");
        //
        // str = Console.ReadLine();
        // b = Convert.ToInt32(str);
        //
        // int result = a + b;
        //
        // Console.WriteLine("The sum = " + result);


        // string str = "1.9";
        // NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
        // {
        //     NumberDecimalSeparator = ".",
        // };
        //
        //
        // double a = Convert.ToDouble(str, numberFormatInfo);
        //
        // Console.WriteLine(a);


        /*
         * Convert parse and tryparse ------------------------------
         */

        // string str = "5";
        // int a = int.Parse(str);
        //
        // string strf = "5.9";
        // NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
        // {
        //     NumberDecimalSeparator = ".",
        // };
        // double b = double.Parse(strf, numberFormatInfo);
        //
        // Console.WriteLine(b);
        //
        // string dataStr = "1sadasd";
        // try
        // {
        //     int c = Convert.ToInt32(dataStr);
        //     Console.WriteLine("Successfully converted");
        //     
        // }
        // catch (Exception)
        // {
        //     Console.WriteLine("Error during convert");
        //    
        // }

        // string str = "1";
        // int a;
        //
        // bool result = int.TryParse(str, out a);
        //
        // Console.WriteLine(a);
        // Console.WriteLine(result);
        //
        // if (result)
        // {
        //     Console.WriteLine("Operation successful, result = ");
        // }
        // else
        // {
        //     Console.WriteLine("Unable to convert!");
        // }

        /*
         * Operators and arithmetic operations with numbers  ------------------------------
         */

        // >>> Operations with numbers is binary operations <<<< //

        // int a = 10;
        //
        // double result = a + 5; 
        //
        // Console.WriteLine(result);


        /*
         * ----------------------- TASKS ----------------------------
         */

        // ------------------------- 1 --------------------------- //
        // Write a program, that calculate average of two numbers //

        // double firstValue, secondValue;
        //
        // Console.WriteLine("Enter first value");
        //
        // firstValue = double.Parse(Console.ReadLine());
        // Console.WriteLine("Enter second value");
        //
        //
        // secondValue = double.Parse(Console.ReadLine());
        //
        // double result = (firstValue + secondValue) / 2;
        //
        // Console.WriteLine("Average value of two numbers = " + result);


        // ------------------------- 2 --------------------------- //
        //  Enter three numbers and return sum and product of numbers //

        // double firstValue, secondValue, thirdValue;
        //
        // Console.WriteLine("Enter first value");
        // firstValue = double.Parse(Console.ReadLine());
        //
        // Console.WriteLine("Enter second value");
        // secondValue = double.Parse(Console.ReadLine());
        //
        // Console.WriteLine("Enter third value");
        // thirdValue = double.Parse(Console.ReadLine());
        //
        // double sumResult = firstValue + secondValue + thirdValue;
        //
        // double result = firstValue * secondValue * thirdValue;
        //
        // Console.WriteLine("Sum of three numbers = " + sumResult);
        // Console.WriteLine("Product of three numbers = " + result);

        // ------------------------- 3 --------------------------- //
        // Write simple currency converter (without possibility dynamically choose currency by user). //
        //Currency set up in hard code and unchangeable. Type of currency up to you.//

        var EuroToUSD = 1.0951;
        var EuroToCAD = 1.4607;
        double EUR;

        Console.WriteLine("Please enter how much Euro wants to exchange >>>: ");
        EUR = double.Parse(Console.ReadLine());
        Console.WriteLine(EUR + " EUR in USD = " + EUR * EuroToUSD);

        Console.WriteLine(EUR + " EUR in CAD = " + EUR * EuroToCAD);
    }
}