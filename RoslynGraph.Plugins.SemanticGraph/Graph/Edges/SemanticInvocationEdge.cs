using RoslynGraph.Models.Graph.Edges;

namespace RoslynGraph.Plugins.SemanticGraph.Graph.Edges;

public class SemanticInvocationEdge : IEdge
{
    public string IdStart { get; set; } = string.Empty;
    public string IdEnd { get; set; } = string.Empty;
    public bool IsExternal { get; set; }
}
