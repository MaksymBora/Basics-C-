namespace Two_Dimensional_Array;

internal class Program
{
    private static void Main(string[] args)
    {
        // int[,] myArray = 
        // {
        //     { 2, 45, 12, 51, 51 },
        //     { 6, 7, 8, 3, 1 },
        //     { 1, 5, 65, 78, 13 },
        //     { 6, 3, 151, 5, 65, }
        // };
        //
        // // myArray[0, 2] = 99;
        //
        // // Console.WriteLine(myArray[0, 2]);
        //
        // foreach (var item in myArray)
        // {
        //     Console.WriteLine(item);
        // }

        // int[,] myArray = 
        // {
        //     { 2, 45, 12, 51, 51 },
        //     { 6, 7, 8, 3, 1 },
        //     { 1, 5, 65, 78, 13 },
        //     { 6, 3, 151, 5, 65, }
        // };

        // Console.WriteLine(myArray.Rank);
        // Console.WriteLine( myArray.GetLength(1));

        // int height = myArray.GetLength(0);
        // int width = myArray.GetLength(1);

        // for (int i = 0; i < myArray.GetLength(0); i++)
        // {
        //     for (int j = 0; j < myArray.GetLength(1); j++)
        //     {
        //         Console.Write(myArray[i,j] + "\t");
        //     }
        //     Console.WriteLine();
        // }

        // int[,] myArray = new int[10, 6];
        //
        // Random random = new Random();
        //
        // for (int i = 0; i < myArray.GetLength(0); i++)
        // {
        //     for (int j = 0; j < myArray.GetLength(1); j++)
        //     {
        //         myArray[i, j] = random.Next(100);
        //     }
        //  
        // }
        //
        // for (int i = 0; i < myArray.GetLength(0); i++)
        // {
        //     for (int j = 0; j < myArray.GetLength(1); j++)
        //     {
        //         Console.Write(myArray[i,j] + "\t");
        //     }
        //     Console.WriteLine();
        // }

        // int[,] myArray = new int[2, 3];
        //
        // for (int i = 0; i < myArray.GetLength(0); i++)
        // {
        //     for (int j = 0; j < myArray.GetLength(1); j++)
        //     {
        //         Console.WriteLine("Y: " + i + " X: " + j);
        //         myArray[i, j] = int.Parse(Console.ReadLine());
        //     }
        // }
        //
        // Console.WriteLine();
        //
        // for (int i = 0; i < myArray.GetLength(0); i++)
        // {
        //     for (int j = 0; j < myArray.GetLength(1); j++)
        //     {
        //         Console.Write(myArray[i, j] + "\t");
        //     }
        //
        //     Console.WriteLine();
        // }
        
        
        string[,] myArray = new string[2, 3];
        
        for (int i = 0; i < myArray.GetLength(0); i++)
        {
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                Console.WriteLine("Y: " + i + " X: " + j);
                myArray[i, j] = Console.ReadLine();
            }
        }

        Console.WriteLine();

        for (int i = 0; i < myArray.GetLength(0); i++)
        {
            for (int j = 0; j < myArray.GetLength(1); j++)
            {
                Console.Write(myArray[i, j] + "\t");
            }

            Console.WriteLine();
        }
    }
}