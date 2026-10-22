
using System;
using System.Collections.Generic;

// Create graph and nodes
Graph graph = new Graph();

Node Start = new Node("Start");
Node A = new Node("A");
Node B = new Node("B (BEES)");
Node C = new Node("C");
Node D = new Node("D (BEES)");
Node E = new Node("E (BEES)");
Node F = new Node("F");
Node G = new Node("G");
Node H = new Node("H");
Node I = new Node("I (BEES)");
Node J = new Node("J (BEES)");
Node K = new Node("K");
Node L = new Node("L");
Node M = new Node("M");
Node N = new Node("N");
Node End = new Node("End");

// Add all 16 nodes to graph
Node[] allNodes =
{
    Start, A, B, C, D, E, F, G,
    H, I, J, K, L, M, N, End
};

foreach (Node node in allNodes)
{
    graph.AddNode(node);
}

// Add 23 weighted edges
graph.AddEdge(Start, A, 1);
graph.AddEdge(Start, B, 5);
graph.AddEdge(Start, D, 5);

graph.AddEdge(A, C, 1);
graph.AddEdge(B, E, 5);

graph.AddEdge(D, C, 5);
graph.AddEdge(D, E, 5);
graph.AddEdge(D, G, 5);

graph.AddEdge(E, H, 5);
graph.AddEdge(C, F, 1);

graph.AddEdge(G, F, 1);
graph.AddEdge(G, H, 1);
graph.AddEdge(G, J, 1);

graph.AddEdge(F, I, 5);
graph.AddEdge(H, K, 1);

graph.AddEdge(J, I, 5);
graph.AddEdge(J, K, 5);
graph.AddEdge(J, M, 5);

graph.AddEdge(I, L, 5);
graph.AddEdge(K, N, 1);

graph.AddEdge(M, L, 1);
graph.AddEdge(M, N, 1);

graph.AddEdge(L, End, 1);

// Dijkstra's algorithm setup.
Node Target = End;

Dictionary<Node, int> DistanceList = new Dictionary<Node, int>();

// Initially all distances are infinite
foreach (Node node in graph.Nodes)
{
    DistanceList[node] = int.MaxValue;
}

// Start node has distance 0
DistanceList[Start] = 0;

// Create priority queue
PriorityQueue<Node, int> priorityQueue =
    new PriorityQueue<Node, int>();

// Store parent of each node
Dictionary<Node, Node?> parents =
    new Dictionary<Node, Node?>();

parents[Start] = null;

// Add Start to priority queue
priorityQueue.Enqueue(Start, 0);

// Dijkstra's algorithm
while (priorityQueue.TryDequeue(out Node? current, out int priority))
{
    if (current == null)
        continue;

    // Skip outdated queue entries
    if (priority != DistanceList[current])
        continue;

    // Stop when target is reached
    if (current == Target)
        break;

    // Check all neighbours of current node
    foreach (KeyValuePair<Node, int> neighbour in current.Edges)
    {
        // Calculate total distance
        int totalDistance = DistanceList[current] + neighbour.Value;

        // Skip if path is not shorter
        if (totalDistance >= DistanceList[neighbour.Key])
            continue;

        // Update shortest distance
        DistanceList[neighbour.Key] = totalDistance;

        // Record parent
        parents[neighbour.Key] = current;

        // Add neighbour to priority queue
        priorityQueue.Enqueue(neighbour.Key, totalDistance);
    }
}

// Print shortest path
if (DistanceList[Target] == int.MaxValue)
{
    Console.WriteLine("No path found.");
}
else
{
    List<string> path = new List<string>();

    Node? node = Target;

    // Trace backwards from End to Start
    while (node != null)
    {
        path.Add(node.Data);
        node = parents[node];
    }

    // Reverse path to Start -> End
    path.Reverse();

    Console.WriteLine("Shortest path:");
    Console.WriteLine(string.Join(" -> ", path));

    Console.WriteLine("Total distance: " + DistanceList[Target]);
}
