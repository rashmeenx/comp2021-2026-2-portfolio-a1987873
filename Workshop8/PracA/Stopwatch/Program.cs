using System.Diagnostics;
using System.Text;

class Program
{
    static void Main()
    {
        Stopwatch appendWatch = new Stopwatch();
        string aOutput = "";

        appendWatch.Start();

        for (int i = 0; i < 100_000; i++)
        {
            aOutput += "z";
        }

        appendWatch.Stop();

        Console.WriteLine($"Append time: {appendWatch.Elapsed.TotalSeconds} seconds");

        Stopwatch buildWatch = new Stopwatch();
        StringBuilder bOutput = new();

        buildWatch.Start();

        for (int i = 0; i < 100_000; i++)
        {
            bOutput.Append("z");
        }

        buildWatch.Stop();

        Console.WriteLine($"Build time: {buildWatch.Elapsed.TotalSeconds} seconds");
    }
}