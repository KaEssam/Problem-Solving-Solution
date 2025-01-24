public class Solution
{
    public IList<int> EventualSafeNodes(int[][] graph)
    {
        var terminalNodes = new HashSet<int>();
        var visited = new HashSet<int>();
        return Enumerable.Range(0, graph.Length).Where(IsTerminal).ToArray();

        bool IsTerminal(int node)
        {
            if(!visited.Contains(node))
            {
                visited.Add(node);
                if(graph[node].All(IsTerminal))
                {
                    terminalNodes.Add(node);
                }
            }
            
            return terminalNodes.Contains(node);
        }
    }
}