public class Graph
{
    public List<Node> Nodes { get; } = new();

    public void AddEdge(Node fromNode, Node toNode, int weight)
    {
        if (!Nodes.Contains(fromNode)) Nodes.Add(fromNode);
        if (!Nodes.Contains(toNode)) Nodes.Add(toNode);

        fromNode.Edges[toNode] = weight;
        toNode.Edges[fromNode] = weight;
    }
}