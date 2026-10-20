class Program
{
    static void Main()
    {
        Graph graph = new Graph();

        Node A = new Node("A");
        Node B = new Node("B");
        Node C = new Node("C");
        Node D = new Node("D");
        Node E = new Node("E");
        Node F = new Node("F");
        Node G = new Node("G");
        Node H = new Node("H");
        Node I = new Node("I");

        graph.AddEdge(A, B);
        graph.AddEdge(A, C);
        graph.AddEdge(B, D);
        graph.AddEdge(B, E);
        graph.AddEdge(C, F);
        graph.AddEdge(D, G);
        graph.AddEdge(E, H);
        graph.AddEdge(F, I);

        Console.WriteLine("\nOriginal Graph DFS:");
        DFS(A, I);

        graph.AddEdge(D, E);
        graph.AddEdge(E, F);
        graph.AddEdge(G, H);
        graph.AddEdge(F, H);
        graph.AddEdge(H, I);

        Console.WriteLine("\nAdjusted Graph DFS:");
        DFS(A, I);
    }


    static void DFS(Node start, Node target)
    {
        Stack<Node> stack = new Stack<Node>();
        HashSet<Node> visited = new HashSet<Node>();
        List<string> checkedNodes = new List<string>();

        stack.Push(start);
        visited.Add(start);

        while (stack.Count > 0)
        {
            Node current = stack.Pop();

            checkedNodes.Add(current.Data);

            if (current == target)
            {
                Console.WriteLine("Target found!");
                break;
            }

            foreach (Node neighbour in current.Edges)
            {
                if (!visited.Contains(neighbour))
                {
                    visited.Add(neighbour);
                    stack.Push(neighbour);
                }
            }
        }

        Console.WriteLine("Checked: " +
            string.Join(" ", checkedNodes));
    }
}