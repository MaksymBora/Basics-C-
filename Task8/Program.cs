using System;
using System.Security.Cryptography;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomNumbers = new Random();
            int[] score = new int[12];
            int count = 100;


            for (int i = 1; i <= count; i++)
            {
                int droppedFirstCubeNumbers = randomNumbers.Next(1, 7);
                int droppedSecondCubeNumbers = randomNumbers.Next(1, 7);
                int totalScore = droppedFirstCubeNumbers + droppedSecondCubeNumbers;
                
                Console.WriteLine(totalScore);
                score[totalScore - 1]++;
            }

            Console.WriteLine("How many times dropped each side: ");


            for (int j = 1; j < score.Length; j++)
            {
                Console.WriteLine($"Score {j + 1}: {score[j]} times");
            }
        }
    }
}