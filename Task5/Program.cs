using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumbers = new Random();
            int[] sides = new int[6];
            int count = 100;


            for (int i = 1; i <= count; i++)
            {
                int droppedNumbers = randomNumbers.Next(1, 7);

                sides[droppedNumbers - 1]++;
            }

            Console.WriteLine("How many times dropped each side: ");


            for (int j = 0; j < sides.Length; j++)
            {
                Console.WriteLine($"Side {j + 1}: {sides[j]} times");
            }


           
        }
    }
}