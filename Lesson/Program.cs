

namespace Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            
            int a, b;
            
            Console.WriteLine("Enter a figure 1");
            str = Console.ReadLine();

            a = Convert.ToInt32(str);
            
            Console.WriteLine("Enter a figure 2");

            str = Console.ReadLine();
            b = Convert.ToInt32(str);

            int result = a + b;
            
            Console.WriteLine("The sum = " + result);

        }
    }
}