namespace MyArray;


internal class Program
{
    private static void Main(string[] args)
    {
        // int[] myArray = Enumerable.Range(4, 5).ToArray();

        // int[] myArray = { 10, 3, 2, 55 };
        
        // Console.Write("Enter quantity of elements in ArMyArrayt");
        // int elementsCount = int.Parse(Console.ReadLine());
        //
        // int[] newArray = new int[elementsCount];
        // for (int i = 0; i < newArray.Length; i++)
        // {
        //     Console.Write($"\nEnter array element with index {i}:\t");
        //     newArray[i] = int.Parse(Console.ReadLine());
        // }
        //
        // Console.WriteLine("Your ArMyArray);
        //
        // for (int i = 0; i < newArray.Length; i++)
        // {
        //     Console.WriteLine(newArray[i]);
        // }

        // for (int i = myArray.Length - 1; i >= 0; i--)
        // {
        //     Console.WriteLine(myArray[i]);
        // }
        
        // int res = 0;
        // for (int i = 0; i < myArray.Length; i++)
        // {
        //    
        //     if (myArray[i] % 2 == 0)
        //     {
        //         res += myArray[i];
        //     }
        //    
        // }
        // Console.WriteLine(res);

        // int minValue = myArray[0];
        // for (int i = 0; i < myArray.Length; i++)
        // {
        //
        //     if (myArray[i] < minValue)
        //     {
        //         minValue = myArray[i];
        //     }
        // }
        //
        // Console.WriteLine(minValue);

        int[] myArray = { 111, 10, 4, 10, 111, 49, 64, 77, 4, 42, 5 };
        
        // Console.WriteLine(myArray.Where(i => i % 2 == 0).Sum());
        // Console.WriteLine(myArray.Where(i => i % 2 != 0).Min());

        // int[] result = myArray.Distinct().ToArray();
        
        // int[] result = myArray.OrderBy(i => i).ToArray();
        // int[] result = myArray.OrderByDescending(i => i).ToArray();
        
        // myArray.Length
        
        
        // Array.Sort(myArray);
       
        
        // Console.WriteLine( Array.Find(myArray, i => i < 70));
        // Console.WriteLine( Array.FindLast(myArray, i => i < 70));

        // int[] result = Array.FindAll(myArray, i => i < 70);
        // Console.WriteLine(result);
        
        // int result = Array.FindIndex(myArray, i => i == 77);
        // Console.WriteLine(result);
        
        // Array.Reverse(myArray);

        // int[] result = myArray.Where(i => i < 70).ToArray();
        
        // int result = myArray.Where(i => i < 70).First();
        
        int result = myArray.Where(i => i < 0).FirstOrDefault();
        
        Console.WriteLine(result);


    }
} 