using System.Diagnostics;
using System.Text.Json;

class Program
{
    static void Main()
    {
        LinkedList<Player> players = new LinkedList<Player>();

        players.AddLast(new Player("Rashmeen", 100, 20, 10));
        players.AddLast(new Player("Alex", 90, 15, 8));
        players.AddLast(new Player("Sam", 120, 25, 12));
        players.AddLast(new Player("Chris", 80, 18, 7));
        players.AddLast(new Player("Jordan", 110, 22, 9));

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