using RoslynGraph.Core;

namespace RoslynGraph.Utils;
public static class GraphEngineFactory
{
    public static GraphEngine Create(string path)
    {
            return new GraphEngine(path);
    }
}
