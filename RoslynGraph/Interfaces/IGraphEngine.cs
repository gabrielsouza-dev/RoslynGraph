using RoslynGraph.Models.Graph;

namespace RoslynGraph.Interfaces;

public interface IGraphEngine
{
    public Task<Graph?> SearchInGraph(string id);
    public Task SearchInSource(string id);
    public Task<Graph> FullScan();
}