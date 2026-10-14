using System.Diagnostics;
using System.Text.Json;

class Program
{
    static void Main()
    {
        List<Player> players = new List<Player>();

        for (int i = 0; i < 10_000; i++)
        {
            players.Add(new Player($"Player{i}", 100, 10, 5));
        }

        string path = @"./Attachments/players.json";

        Directory.CreateDirectory("./Attachments");

        FileWriter(path, players);

        List<Player> loadedPlayers =
            FileReader<List<Player>>(path);

        GC.Collect();

        long heapSize = GC.GetGCMemoryInfo().HeapSizeBytes;
        long peakMemory = Process.GetCurrentProcess().PeakWorkingSet64;

        Console.WriteLine($"Heap Size: {heapSize} bytes");
        Console.WriteLine($"Peak Working Set: {peakMemory} bytes");
    }

    public static void FileWriter<T>(string path, T objectToWrite) where T : class
    {
        string jsonString = JsonSerializer.Serialize(objectToWrite);
        File.WriteAllText(path, jsonString);
    }

    public static T FileReader<T>(string path) where T : class
    {
        string jsonString = File.ReadAllText(path);

        T loadedObject = JsonSerializer.Deserialize<T>(jsonString)!;

        return loadedObject;
    }
}