
public class Graph
{
    public List<Node> Nodes { get; set; }

    public Graph()
    {
        Nodes = new List<Node>();
    }

    public void AddNode(Node node)
    {
        Nodes.Add(node);
    }

    public void AddEdge(Node fromNode, Node toNode, int weight)
    {
        fromNode.Edges.Add(toNode, weight);
        toNode.Edges.Add(fromNode, weight);
    }
}
