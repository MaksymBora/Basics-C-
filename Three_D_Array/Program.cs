namespace Three_D_Array;

internal class Program
{
    private static void Main(string[] args)
    {
        // int[,,] myArray = new int[4, 3, 5];
        //
        // myArray[0, 2, 3] = 55;

        // int[,,] myArray =
        // {
        //     {
        //         { 2, 3, 5 },
        //         { 69, 7, 4 }
        //     },
        //     {
        //         { 24, 31, 54 },
        //         { 61, 7, 42 }
        //     },
        //     {
        //         { 5, 12, 52 },
        //         { 9, 15, 12 }
        //     }
        // };

        // int[,,] myArray = new int[4, 3, 5];
        //
        // Random random = new Random();
        // for (int i = 0; i < myArray.GetLength(0); i++)
        // {
        //     for (int j = 0; j < myArray.GetLength(1); j++)
        //     {
        //         for (int k = 0; k < myArray.GetLength(2); k++)
        //         {
        //             myArray[i, j, k] = random.Next(50);
        //         }
        //     }
        // }
        //
        // for (int i = 0; i < myArray.GetLength(0); i++)
        // {
        //     Console.WriteLine("Page #: " + (i + 1));
        //     
        //     for (int j = 0; j < myArray.GetLength(1); j++)
        //     {
        //         for (int k = 0; k < myArray.GetLength(2); k++)
        //         {
        //             Console.Write(myArray[i, j, k] + " ");
        //         }
        //         Console.WriteLine();
        //     }
        //     
        //     Console.WriteLine("==============================");
        // }
        
        
        // ----- 3D Stepped Array --------- //
        Random random = new Random();
        int[][][] myArray = new int[random.Next(3, 6)][][];

        for (int i = 0; i < myArray.Length; i++)
        {
            myArray[i] = new int[random.Next(2, 6)][];

            for (int j = 0; j < myArray[i].Length; j++)
            {
                myArray[i][j] = new int[random.Next(2, 6)];
                for (int k = 0; k < myArray[i][j].Length; k++)
                {
                    myArray[i][j][k] = random.Next(50);
                }
            }
        }
        
        for (int i = 0; i < myArray.Length; i++)
        {
            Console.WriteLine("Page #: " + (i + 1));

            for (int j = 0; j < myArray[i].Length; j++)
            {
                for (int k = 0; k < myArray[i][j].Length; k++)
                {
                    Console.Write(myArray[i][j][k] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}