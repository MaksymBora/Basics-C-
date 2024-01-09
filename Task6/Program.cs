using System;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumbers = new Random();
            int sideSix = 0;
            // int x = 5;


            while (sideSix != 10)
            {
                int droppedNumbers = randomNumbers.Next(1, 7);
                Console.WriteLine(droppedNumbers);
                
                if (droppedNumbers == 6)
                {
                    sideSix++;
                } 
                
                if (sideSix == 10)
                {
                    Console.WriteLine("Side 6 dropped 10 times!");
                }
            }
        }
    }
}