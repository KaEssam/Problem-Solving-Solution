public class Solution {
    public int MagnificentSets(int n, int[][] edges) {
        List<List<int>> graph = new List<List<int>>();
        for (int i = 0; i <= n; i++) {
            graph.Add(new List<int>());
        }
        foreach (var edge in edges) {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }
    
        int[] colors = new int[n + 1]; 
        Array.Fill(colors, 0);

        int totalGroups = 0;
        bool[] visited = new bool[n + 1];

        for (int i = 1; i <= n; i++) {
            if (visited[i]) continue;

            List<int> component = new List<int>();
            if (!IsBipartite(i, graph, colors, visited, component)) {
                return -1; 
            }

            int maxGroups = FindMaxGroups(component, graph);
            totalGroups += maxGroups;
        }

        return totalGroups;
    }

    private bool IsBipartite(int start, List<List<int>> graph, int[] colors, bool[] visited, List<int> component) {
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(start);
        colors[start] = 1; 
        visited[start] = true;

        while (queue.Count > 0) {
            int node = queue.Dequeue();
            component.Add(node);

            foreach (int neighbor in graph[node]) {
                if (colors[neighbor] == 0) { 
                    colors[neighbor] = -colors[node]; 
                    visited[neighbor] = true;
                    queue.Enqueue(neighbor);
                } else if (colors[neighbor] == colors[node]) {
                    return false; 
                }
            }
        }
        return true;
    }
    private int FindMaxGroups(List<int> component, List<List<int>> graph) {
        int maxGroups = 0;

        foreach (int node in component) {
            maxGroups = Math.Max(maxGroups, BfsDepth(node, graph));
        }

        return maxGroups;
    }
    private int BfsDepth(int start, List<List<int>> graph) {
        Queue<int> queue = new Queue<int>();
        Dictionary<int, int> depth = new Dictionary<int, int>();
        queue.Enqueue(start);
        depth[start] = 1;

        int maxDepth = 1;
        while (queue.Count > 0) {
            int node = queue.Dequeue();
            int currentDepth = depth[node];

            foreach (int neighbor in graph[node]) {
                if (!depth.ContainsKey(neighbor)) {
                    depth[neighbor] = currentDepth + 1;
                    maxDepth = Math.Max(maxDepth, currentDepth + 1);
                    queue.Enqueue(neighbor);
                }
            }
        }
        return maxDepth;
    }
}