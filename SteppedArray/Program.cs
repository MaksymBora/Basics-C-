namespace SteppedArray;

internal class Program
{
    private static void Main(string[] args)
    {
        int[][] myArray = new int [3][];
        myArray[0] = new int[5];
        myArray[1] = new int[2];
        myArray[2] = new int[10];

        // myArray[0][3] = 55;
        // Console.WriteLine(myArray[0][3]);
        Random random = new Random();

        for (int i = 0; i < myArray.Length; i++)
        {
            for (int j = 0; j < myArray[i].Length; j++)
            {
                myArray[i][j] = random.Next(50);
            }
        }
        
        for (int i = 0; i < myArray.Length; i++)
        {
            for (int j = 0; j < myArray[i].Length; j++)
            {
               Console.Write(myArray[i][j] + "\t");
            }
            Console.WriteLine();
        }
    }
}