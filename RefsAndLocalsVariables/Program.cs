namespace RefsAndLocalsVariables
{
    class Program
    {
        static ref int Foo(int[] numbers)
        {
            return ref numbers[0];
        }
        
        static void Main(string[] args)
        {
            int[] arr = { 2, 6, 1 };
            
            // ref int b = ref arr[0];
            //
            // b = -5;

            ref int b = ref Foo(arr);

            b = -5;
        }
    }
}