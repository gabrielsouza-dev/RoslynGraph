using RoslynGraph.Core;
using RoslynGraph.Interfaces;
using RoslynGraph.Models.Graph.Edges;
using RoslynGraph.Models.Graph.Nodes;
using RoslynGraph.Plugins.SemanticGraph.Graph.Edges;
using RoslynGraph.Plugins.SemanticGraph.Graph.Nodes;
using System.Threading.Channels;
using RoslynGraph.Plugins.SemanticGraph.Graph;

namespace RoslynGraph.Plugins.SemanticGraph.Core;
public class SemanticGraphEngine : IGraphEngine
{
    private readonly GraphEngine _graphEngine;
    private readonly GraphWorkspace<SemanticGraphh, SemanticDeclarationNode, SemanticInvocationEdge> _semanticWorkspace;
    private readonly Channel<DeclarationNode> _nodeChannel;
    private readonly Channel<InvocationEdge> _edgeChannel;

    public SemanticGraphEngine(GraphEngine graphEngine, string path)
    {
        _graphEngine = graphEngine;
        _semanticWorkspace = new GraphWorkspace<SemanticGraphh, SemanticDeclarationNode, SemanticInvocationEdge>(path);
        _nodeChannel = Channel.CreateUnbounded<DeclarationNode>();
        _edgeChannel = Channel.CreateUnbounded<InvocationEdge>();
    }

    private async Task InitializeAsync()
    {
        _ = Task.Run(() => ListeningNodes(_nodeChannel));
        _ = Task.Run(() => ListeningEdges(_edgeChannel));
    }

    private async Task ListeningNodes(Channel<DeclarationNode> channel)
    {
        await foreach (var node in channel.Reader.ReadAllAsync())
        {
            throw new NotImplementedException();
        }
    }

    private async Task ListeningEdges(Channel<InvocationEdge> channel)
    {
        await foreach (var edge in channel.Reader.ReadAllAsync())
        {
            throw new NotImplementedException();
        }
    }

    public Task<Models.Graph.Graph?> SearchInGraph(string id)
    {
        throw new NotImplementedException();
    }

    public Task SearchInSource(string id)
    {
        throw new NotImplementedException();
    }

    public Task<Models.Graph.Graph> FullScan()
    {
        throw new NotImplementedException();
    }

    //public override async Task<Graph?> SearchInGraph(string id)
    //{
    //    var graph = await base.SearchInGraph(id);

    //    return graph;
    //}
}
