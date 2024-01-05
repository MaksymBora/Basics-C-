namespace Task1;

internal class Program
{
    private static void Main(string[] args)
    {
        var count = -100;
        var number = 100;


        while (count <= number)
        {
            if (count == 0)
                Console.WriteLine(count);
            else if (count % 7 == 0)
                Console.WriteLine("PIEP");
            else
                Console.WriteLine(count);

            count++;
        }

        // while (count <= number)
        // {
        //     if (count % 2 == 0)
        //     {
        //         Console.WriteLine(count);
        //     }
        //     
        //     count++;
        // }

        // while (count <= number)
        // {
        //     if (count % 2 != 0)
        //     {
        //         Console.WriteLine(count);
        //     }
        //     
        //     count++;
        // }
    }
}