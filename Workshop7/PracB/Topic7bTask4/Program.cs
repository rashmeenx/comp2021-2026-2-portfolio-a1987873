using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var eventQueue2 = new PriorityQueue<Player, Priority>();

        eventQueue2.Enqueue(new Player("Alice"), Priority.MediumPriority);
        eventQueue2.Enqueue(new Player("Bob"), Priority.HighPriority);
        eventQueue2.Enqueue(new Player("Charlie"), Priority.LowPriority);
        eventQueue2.Enqueue(new Player("Diana"), Priority.MediumPriority);
        eventQueue2.Enqueue(new Player("Ethan"), Priority.LowPriority);

        Console.WriteLine("Adding Fiona with same priority as Bob (HighPriority)...");
        eventQueue2.Enqueue(new Player("Fiona"), Priority.HighPriority);

        Console.WriteLine("\n=== Processing Event Queue 2 ===");
        while (eventQueue2.Count != 0)
        {
            Console.WriteLine(eventQueue2.Dequeue());
        }
    }
}