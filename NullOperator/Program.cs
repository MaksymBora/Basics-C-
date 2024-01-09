namespace NullOperator
{
    class Program
    {
        // static int[] GetArray()
        // {
        //     int[] myArray = new int[11];
        //     
        //     return myArray;
        // }

        static int[] GetArray()
        {
            // int[] myArray = { 1, 2, 3 };
            int[] myArray = null;
            return myArray;
        }
        
        static void Main(string[] args)
        {
            // string str = null;

            // string result = str ?? "default string";
            // str ??= string.Empty;
            //
            // Console.WriteLine("Quantity of symbols in string " + str.Length);

            // int[] myArray = GetArray();
            //
            // myArray ??= new int[0];
            //
            // Console.WriteLine("Quantity of symbols in string " + myArray.Length);

            int[] myArray = GetArray();
            
            Console.WriteLine("Sum of all elements in Array " + (myArray?.Sum() ?? 0));
        }
    }
}