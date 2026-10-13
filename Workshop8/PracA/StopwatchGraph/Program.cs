using System.Diagnostics;
using System.Text;

class Program
{
    static void Main()
    {
        int iterations = 20;

        List<double> appendElapsedList = new List<double>();
        List<double> builderElapsedList = new List<double>();

        Stopwatch watch = new Stopwatch();

        for (int pass = 1; pass <= iterations; pass++)
        {
            string aOutput = "";

            watch.Restart();

            for (int i = 0; i < pass * 10_000; i++)
            {
                aOutput += "z";
            }

            watch.Stop();

            appendElapsedList.Add(watch.Elapsed.TotalSeconds);
        }

        for (int pass = 1; pass <= iterations; pass++)
        {
            StringBuilder bOutput = new();

            watch.Restart();

            for (int i = 0; i < pass * 10_000; i++)
            {
                bOutput.Append("z");
            }

            watch.Stop();

            builderElapsedList.Add(watch.Elapsed.TotalSeconds);
        }

        ScottPlot.Plot appendPlot = new();

        appendPlot.Add.Bars(appendElapsedList.ToArray());

        appendPlot.Title("String Append Performance");
        appendPlot.XLabel("Pass");
        appendPlot.YLabel("Time (seconds)");

        appendPlot.SavePng("appendPlot.png", 800, 600);


        ScottPlot.Plot buildPlot = new();

        buildPlot.Add.Bars(builderElapsedList.ToArray());

        buildPlot.Title("StringBuilder Performance");
        buildPlot.XLabel("Pass");
        buildPlot.YLabel("Time (seconds)");

        buildPlot.SavePng("buildPlot.png", 800, 600);

        Console.WriteLine("Graphs saved.");
    }
}