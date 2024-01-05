using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int shot = 1;
            Random randomNumbers = new Random();

            // while (true)
            // {
            //     int droppedNumber = randomNumbers.Next(1, 7);
            //     
            //     Console.WriteLine(droppedNumber);
            //     if (droppedNumber == 6) 
            //         break;
            //     shot++;
            // }
            
            while (true)
            {
                Console.WriteLine("Press enter to roll the dice!");
                Console.ReadLine();
                
                int droppedNumber = randomNumbers.Next(1, 7);
                
                Console.WriteLine("): Your result is " + droppedNumber);
                Console.WriteLine("Try again!");

                if (droppedNumber == 6)
                {
                    Console.WriteLine("Congratulation! You are won!");
                    break;
                }
                    
                shot++;
            }
            
            
            
            Console.WriteLine("You made " + shot + " shots!");
        }
    }
}