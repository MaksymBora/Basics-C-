namespace Lesson_Core;


internal class Program
{
    private static void Main(string[] args)
    {
        int[] myArray = { 2, 10, 5, 6, 77, 89};
        
        // Console.WriteLine(myArray[^1]); // last elements in array

        // int[] myArray2 = myArray[1..4];
        // int[] myArray2 = myArray[..4];

        // Index myIndex = ^1;
        // Index myIndex = new Index(3, true);
        //
        // Console.WriteLine(myArray[myIndex]);
        // Console.WriteLine($"value {myIndex.Value} isFromEnd {myIndex.IsFromEnd}");

        // Range myRange = new Range(1, 4);
        // Range myRange = ^4..^1;
        //
        // int[] myArray2 = myArray[myRange];

        string str = "Hello World !!! =)";
        
        Console.WriteLine(str[^2..]);

    }
} 