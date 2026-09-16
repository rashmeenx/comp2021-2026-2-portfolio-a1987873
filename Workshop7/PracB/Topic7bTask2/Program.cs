using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var players = new List<(ScoreEntry entry, Player player)>
        {
            (new ScoreEntry(85, 3), new Player("Alice")),
            (new ScoreEntry(92, 4), new Player("Bob")),
            (new ScoreEntry(47, 1), new Player("Charlie")),
            (new ScoreEntry(63, 2), new Player("Diana")),
            (new ScoreEntry(78, 3), new Player("Ethan")),
            (new ScoreEntry(55, 2), new Player("Fiona")),
            (new ScoreEntry(99, 5), new Player("George")),
            (new ScoreEntry(31, 1), new Player("Hannah")),
            (new ScoreEntry(70, 3), new Player("Ian")),
            (new ScoreEntry(88, 4), new Player("Julia")),
        };

        var sortedScores2 = new SortedDictionary<ScoreEntry, Player>(new ScoreComparer());
        foreach (var (entry, player) in players)
        {
            sortedScores2.Add(entry, player);
        }

        Console.WriteLine("=== Top 3 Scores ===");
        foreach (var kvp in sortedScores2.Reverse().Take(3))
        {
            Console.WriteLine($"{kvp.Value.Name}: {kvp.Key.Score} (Stage {kvp.Key.StageReached})");
        }

        Console.WriteLine("\n=== Bottom 3 Scores ===");
        foreach (var kvp in sortedScores2.Take(3))
        {
            Console.WriteLine($"{kvp.Value.Name}: {kvp.Key.Score} (Stage {kvp.Key.StageReached})");
        }

        var charlieEntry = sortedScores2.First(kvp => kvp.Value.Name == "Charlie").Key;
        sortedScores2.Remove(charlieEntry);

        Console.WriteLine("\n=== Remaining Players ===");
        foreach (var kvp in sortedScores2)
        {
            Console.WriteLine($"{kvp.Value.Name}: {kvp.Key.Score} (Stage {kvp.Key.StageReached})");
        }

        Console.WriteLine("\nAdding Kevin with same score as Bob (92) but different stage...");
        try
        {
            sortedScores2.Add(new ScoreEntry(92, 6), new Player("Kevin"));
            Console.WriteLine("Added successfully — comparer breaks the tie via StageReached.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"ERROR: {ex.Message}");
        }

        Console.WriteLine("\nAdding same Bob object again with a different score (40)...");
        var bobObject = sortedScores2.First(kvp => kvp.Value.Name == "Bob").Value;
        try
        {
            sortedScores2.Add(new ScoreEntry(40, 1), bobObject);
            Console.WriteLine("Added successfully — dictionary doesn't check value uniqueness, only key uniqueness.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"ERROR: {ex.Message}");
        }

        Console.WriteLine("\n=== Final List ===");
        foreach (var kvp in sortedScores2)
        {
            Console.WriteLine($"{kvp.Value.Name}: {kvp.Key.Score} (Stage {kvp.Key.StageReached})");
        }
    }
}