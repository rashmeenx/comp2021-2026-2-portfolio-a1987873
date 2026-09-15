using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        SortedSet<int> scores = new SortedSet<int>();
        Random random = new Random();

        // 1. Add 10 random scores
        while (scores.Count < 10)
        {
            scores.Add(random.Next(0, 101));
        }

        Console.WriteLine("Original Scores:");
        DisplayScores(scores);

        // 2. Add a new high score
        Console.WriteLine("\nAfter adding new high score:");

        scores.Add(150);

        DisplayScores(scores);

        // 3. Add a duplicate score
        Console.WriteLine("\nAfter trying to add duplicate score:");

        int duplicateScore = scores.Min;
        scores.Add(duplicateScore);

        DisplayScores(scores);
    }

    static void DisplayScores(SortedSet<int> scores)
    {
        Console.WriteLine("Scores:");

        foreach (int score in scores)
        {
            Console.WriteLine(score);
        }

        Console.WriteLine($"Lowest Score: {scores.Min}");
        Console.WriteLine($"Highest Score: {scores.Max}");
    }
}