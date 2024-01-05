
namespace Task3;

internal class Program
{
    private static void Main(string[] args)
    {

        int value = int.Parse(Console.ReadLine());
       

        // ------------- Square ---------------- //
        for (int i = 1; i <= value; i++)
        {
            int squareResult = i * i;
            Console.WriteLine(squareResult);
        }
        
        Console.WriteLine("---------------------");
        
        // ------------- Exponents ---------------- //
        for (int i = 1; i <= value; i++)
        {
            int exponents = (int)Math.Pow(2, i);
            Console.WriteLine(exponents);
        }
        
        Console.WriteLine("---------------------");
        
        // ------------- Factorial ---------------- //
        int factorial = 1;
        
        for (int i = 1; i <= value; i++)
        {
            factorial *= i;
            
            Console.WriteLine(factorial);
        }
    }
}