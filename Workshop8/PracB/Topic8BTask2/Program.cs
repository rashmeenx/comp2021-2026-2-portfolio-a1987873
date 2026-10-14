using System.Diagnostics;
using System.Text.Json;

class Program
{
    static void Main()
    {
        LinkedList<Player> players = new LinkedList<Player>();

        for (int i = 0; i < 10_000; i++)
        {
            players.AddLast(new Player($"Player{i}", 100, 10, 5));
        }

        string path = @"./Attachments/players.json";

        Directory.CreateDirectory("./Attachments");

        FileWriter(path, players);

        LinkedList<Player> loadedPlayers =
            FileReader<LinkedList<Player>>(path);

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