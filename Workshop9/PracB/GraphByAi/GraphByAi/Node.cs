public class Node
{
    public string Data { get; }
    public Dictionary<Node, int> Edges { get; } = new();

    public Node(string data) { Data = data; }
}