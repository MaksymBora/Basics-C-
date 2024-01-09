namespace Refs
{

    // struct MyStruct
    // {
    //     public int a;
    //     public double b;
    //     public float c;
    // }
    
    class MyClass
    {
        public int a;
        public double b;
        public float c;
    }
    
    class Program
    {
        // static void Foo(ref int a)
        // {
        //     a = -5;
        // }
        
        static void Foo(MyClass myClass)
        {
            myClass.a = -5;
        }

        // static void Bar(ref int[] myArray)
        // {
        //     // myArray[0] = -5;
        //     myArray = null;
        // }
        
        static void Bar(ref int[] arr)
        {
            arr = new int[10];
        }
        
        static void Main(string[] args)
        {
            // int a = -2;
            //
            // Foo(ref a);
            // Console.WriteLine(a);

            // MyClass myClass = new MyClass();
            //
            // Foo(myClass);

            // int[] myArray = { 1, 4, 6 };
            // Bar(ref myArray);
            //
            // Console.WriteLine(myArray[0]);
            
            int[] myArray = { 1, 4, 6 };
            
             Bar(ref myArray);
             
        }
    }
}