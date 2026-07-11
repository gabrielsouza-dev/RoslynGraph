using RoslynGraph.Core;
using RoslynGraph.Plugins.SemanticGraph.Core;
using RoslynGraph.Utils;

namespace RoslynGraph.Plugins.SemanticGraph.Utils;

public static class GraphEngineExtensions
{
    public static SemanticGraphEngine AsSemanticGraph(this GraphEngine graphEngine, string path)
    {
        return new SemanticGraphEngine(graphEngine, path);
    }
}
