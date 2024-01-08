using System.Xml;

namespace Methods
{
    class Program
    {
        static int Sum(int a, int b)
        {
            int result = a + b;
        
            return result;
        }

        static void PrintResult(int result)
        {
            Console.WriteLine("Sum Result: " + result);
        }
        
        static void Main(string[] args)
        {
            int a, b, c;
        
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
        
           c =  Sum(a, b);
        
           PrintResult(c);
           Console.WriteLine("=============");
        }
        
        
        // ------------------- Option 2 ---------------------- //
        
        // static void PrintLine()
        // {
        //     Console.WriteLine("Method PrintLine has been called! ");
        // }
        //
        // static void Main(string[] args)
        // {
        //    PrintLine();
        // }
        
    }
}