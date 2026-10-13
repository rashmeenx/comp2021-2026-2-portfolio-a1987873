using System.IO;

class Program
{
    static void Main()
    {
        string path = @"./MyTest.txt";

        using (StreamWriter sw = File.CreateText(path))
        {
            sw.WriteLine("Hello World");
            sw.WriteLine("This is Topic 8 Prac B");
        }

        using (StreamReader sr = File.OpenText(path))
        {
            string? s;

            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
        }
    }
}