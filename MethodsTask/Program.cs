using System.Xml;

namespace Methods
{
    class Program
    {


        static void PrintLine(string str, uint value)
        {
            for (int i = 0; i < value; i++)
            {
                Console.Write(str);
            }
        }

        // static void SearchElement(string str, string element)
        // {
        //     return Array.Find(str, i => i == element);
        // }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a symbol!");
            string str = Console.ReadLine();
            Console.WriteLine("Enter a value!");
            uint value = uint.Parse(Console.ReadLine());
            
            PrintLine(str, value);

            // string str = Console.ReadLine();
            // string element = Console.ReadLine();
            //
            // SearchElement(str, element);

        }
        
    }
}