using System;

namespace LessonTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------------- Increment and Decrement. Postfix & prefix -------------------// 
            // int a = 0;
            // a++; // postfix - less priority
            // ++a; // pretfix - more prioriry

            int a = 1;

            a = ++a * a;
            
            Console.WriteLine(a);
            
        }
    }
}