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

        string path = @"./Attachments/players.json";

        Directory.CreateDirectory("./Attachments");

        // Changed: instead of serializing and writing here, we now call the FileWriter method
        FileWriter(path, players);

        // Changed: instead of reading and deserializing here, we now call the FileReader method
        List<Player> loadedPlayers = FileReader<List<Player>>(path);

        foreach (Player player in loadedPlayers)
        {
            Console.WriteLine(
                $"{player.Name} - HP: {player.Health}, ATK: {player.Attack}, DEF: {player.Defence}"
            );
        }
    }

    // Changed: new reusable method for writing JSON to a file
    public static void FileWriter<T>(string path, T objectToWrite) where T : class
    {
        string jsonString = JsonSerializer.Serialize(objectToWrite);
        File.WriteAllText(path, jsonString);
    }

    // Changed: new reusable method for reading JSON from a file
    public static T FileReader<T>(string path) where T : class
    {
        string jsonString = File.ReadAllText(path);

        T loadedObject = JsonSerializer.Deserialize<T>(jsonString)!;

        return loadedObject;
    }
}