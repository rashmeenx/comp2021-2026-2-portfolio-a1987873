using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var eventQueue = new PriorityQueue<Player, int>();

        eventQueue.Enqueue(new Player("Alice"), 3);
        eventQueue.Enqueue(new Player("Bob"), 1);
        eventQueue.Enqueue(new Player("Charlie"), 5);
        eventQueue.Enqueue(new Player("Diana"), 2);
        eventQueue.Enqueue(new Player("Ethan"), 4);

        Console.WriteLine("Adding Fiona with same priority as Bob (1).");
        eventQueue.Enqueue(new Player("Fiona"), 1);

        Console.WriteLine("\nProcessing Event Queue: ");
        while (eventQueue.Count != 0)
        {
            Console.WriteLine(eventQueue.Dequeue());
        }
    }
}