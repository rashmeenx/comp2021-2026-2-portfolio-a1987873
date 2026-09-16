using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var sortedScores = new SortedDictionary<int, string>();

        sortedScores.Add(85, "Alice");
        sortedScores.Add(92, "Bob");
        sortedScores.Add(47, "Charlie");
        sortedScores.Add(63, "Diana");
        sortedScores.Add(78, "Ethan");
        sortedScores.Add(55, "Fiona");
        sortedScores.Add(99, "George");
        sortedScores.Add(31, "Hannah");
        sortedScores.Add(70, "Ian");
        sortedScores.Add(88, "Julia");

        Console.WriteLine("Top 3 Scores: ");
        foreach (var kvp in sortedScores.Reverse().Take(3))
        {
            Console.WriteLine($"{kvp.Value}: {kvp.Key}");
        }

        Console.WriteLine("\nBottom 3 Scores: ");
        foreach (var kvp in sortedScores.Take(3))
        {
            Console.WriteLine($"{kvp.Value}: {kvp.Key}");
        }

        // Removing a player who has left the game
        Console.WriteLine("\nRemoving Charlie (score 47)");
        sortedScores.Remove(47);

        Console.WriteLine("\nRemaining Players: ");
        foreach (var kvp in sortedScores)
        {
            Console.WriteLine($"{kvp.Value}: {kvp.Key}");
        }

        // Adding a player with a duplicate score, different name
        Console.WriteLine("\nAttempting to add duplicate score (92) for 'Kevin'.");
        try
        {
            sortedScores.Add(92, "Kevin"); 
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"ERROR: {ex.Message}");
        }

        // Adding a player with the same name, different score
        Console.WriteLine("\nAttempting to add duplicate name 'Bob' with new score (40)...");
        try
        {
            sortedScores.Add(40, "Bob");
            Console.WriteLine("Added successfully — no exception, because the KEY (40) was unique.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"ERROR: {ex.Message}");
        }

        Console.WriteLine("\nFinal Player List: ");
        foreach (var kvp in sortedScores)
        {
            Console.WriteLine($"{kvp.Value}: {kvp.Key}");
        }
    }
}