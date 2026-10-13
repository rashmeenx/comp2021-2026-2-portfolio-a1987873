using System.Text.Json;

class Program
{
    static void Main()
    {
        List<Player> players = new List<Player>
        {
            new Player("Rashmeen", 100, 20, 10),
            new Player("Alex", 90, 15, 8),
            new Player("Sam", 120, 25, 12),
            new Player("Chris", 80, 18, 7),
            new Player("Jordan", 110, 22, 9)
        };

        string jsonString = JsonSerializer.Serialize(players);

        Console.WriteLine(jsonString);

        string path = @"./Attachments/players.json";

        Directory.CreateDirectory("./Attachments");

        File.WriteAllText(path, jsonString);

        string loadedJson = File.ReadAllText(path);

        List<Player> loadedPlayers =
            JsonSerializer.Deserialize<List<Player>>(loadedJson)!;

        foreach (Player player in loadedPlayers)
        {
            Console.WriteLine(
                $"{player.Name} - HP: {player.Health}, ATK: {player.Attack}, DEF: {player.Defence}"
            );
        }
    }
}