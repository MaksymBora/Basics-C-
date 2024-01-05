using System;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumbers = new Random();
            

            while (true)
            {
                int droppedNumbersOne = randomNumbers.Next(1, 7);
                int droppedNumbersTwo = randomNumbers.Next(1, 7);
                
                Console.WriteLine($"{droppedNumbersOne} {droppedNumbersTwo}");
               
                if (droppedNumbersOne == droppedNumbersTwo)
                {
                   Console.WriteLine("A pair came up");
                   break;
                } 
                
                Console.WriteLine("A pair didn't come up :(");
                
            }
        }
    }
}