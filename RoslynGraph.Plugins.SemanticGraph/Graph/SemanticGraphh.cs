using RoslynGraph.Models.Graph;
using RoslynGraph.Plugins.SemanticGraph.Graph.Edges;
using RoslynGraph.Plugins.SemanticGraph.Graph.Nodes;

namespace RoslynGraph.Plugins.SemanticGraph.Graph;

public class SemanticGraphh : IGraph<SemanticDeclarationNode, SemanticInvocationEdge>
{
    public List<SemanticDeclarationNode> Nodes { get; set; } = new List<SemanticDeclarationNode>();
    public List<SemanticInvocationEdge> Edges { get; set; } = new List<SemanticInvocationEdge>();

}