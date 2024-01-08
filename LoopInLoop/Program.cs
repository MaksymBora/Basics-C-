namespace LoopInLoop;

internal class Program
{
    private static void Main(string[] args)
    {
        // Console.Write("Enter height of rectangle: ");
        // int height = int.Parse(Console.ReadLine());
        //
        // Console.Write("Enter width of rectangle: ");
        // int width = int.Parse(Console.ReadLine());
        //
        // for (int j = 0; j < height; j++)
        // {
        //     for (int i = 0; i < width; i++)
        //     {
        //         Console.Write("#");
        //     }
        //     Console.WriteLine();
        // }
        
        // Console.Write("Enter height of triangle: ");
        // int height = int.Parse(Console.ReadLine());
        //
        //
        // for (int i = 0; i < height; i++)
        // {
        //     for (int j = height; j > i; j--)
        //     {
        //         Console.Write("*");
        //     }
        //     Console.WriteLine();
        // }
        
        Console.Write("Enter height of triangle: ");
        int height = int.Parse(Console.ReadLine());
        
        for (int j = 0; j < height; j++)
        {
            for (int i = height; i > j; i--)
            {
                Console.Write(" ");
            }

            for (int k = 0; k <= j; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}