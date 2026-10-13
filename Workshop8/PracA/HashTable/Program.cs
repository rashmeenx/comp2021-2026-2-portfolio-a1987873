using System.Collections;

class Program
{
    static void Main()
    {
        Hashtable scoreHash = new Hashtable();

        Player player1 = new Player("Rashmeen");
        Player player2 = new Player("Alex");
        Player player3 = new Player("Sam");
        Player player4 = new Player("Chris");
        Player player5 = new Player("Jordan");

        scoreHash.Add(player1, 85);
        scoreHash.Add(player2, 120);
        scoreHash.Add(player3, 95);
        scoreHash.Add(player4, 70);
        scoreHash.Add(player5, 110);

        scoreHash.Add("Not a Player", 50);
        scoreHash.Remove("Not a Player");

        List<DictionaryEntry> sortedScores = new List<DictionaryEntry>();

        foreach (DictionaryEntry entry in scoreHash)
        {
            sortedScores.Add(entry);
        }

        sortedScores.Sort((a, b) =>
            ((int)b.Value!).CompareTo((int)a.Value!)
        );

        foreach (DictionaryEntry entry in sortedScores)
        {
            Player player = (Player)entry.Key!;
            int score = (int)entry.Value!;

            Console.WriteLine($"{player.Name}: {score}");
        }
    }
}