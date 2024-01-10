using System;

namespace Task12
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("How many players:");
            int numberOfPlayers = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int[] playerScores = new int[numberOfPlayers];

            for (int round = 1; ; round++)
            {
                Console.WriteLine($"\nRound {round}");

                for (int i = 0; i < numberOfPlayers; i++)
                {
                    Console.WriteLine($"\nPlayer {i + 1}");

                    int remainingScore = playerScores[i] == 0 ? 301 : playerScores[i];

                    for (int j = 0; j < 2; j++)
                    {
                        int score = random.Next(1, 51);
                        Console.WriteLine($"Shoot {j + 1}: {score} scores");

                        if (remainingScore - score >= 0)
                        {
                            remainingScore -= score;
                        }

                        if (remainingScore == 0)
                        {
                            Console.WriteLine($"Player {i + 1} completed the game with score 0!");
                            return;
                        }
                    }

                    Console.WriteLine($"Scores Remained for Player {i + 1}: {remainingScore}");
                    playerScores[i] = remainingScore;
                }
            }
        }
    }
}