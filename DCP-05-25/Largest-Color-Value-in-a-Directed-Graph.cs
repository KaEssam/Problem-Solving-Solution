public class Solution {
    public int LargestPathValue(string colors, int[][] edges) {
         int n = colors.Length;
        var graph = new List<int>[n];
        var indegree = new int[n];

        for (int i = 0; i < n; i++) {
            graph[i] = new List<int>();
        }

        foreach (var edge in edges) {
            int from = edge[0], to = edge[1];
            graph[from].Add(to);
            indegree[to]++;
        }

        var queue = new Queue<int>();
        for (int i = 0; i < n; i++) {
            if (indegree[i] == 0) {
                queue.Enqueue(i);
            }
        }

        int[,] dp = new int[n, 26];
        int processed = 0;
        int maxColorValue = 0;

        while (queue.Count > 0) {
            int node = queue.Dequeue();
            processed++;

            int colorIndex = colors[node] - 'a';
            dp[node, colorIndex]++;
            maxColorValue = Math.Max(maxColorValue, dp[node, colorIndex]);

            foreach (int neighbor in graph[node]) {
                for (int c = 0; c < 26; c++) {
                    dp[neighbor, c] = Math.Max(dp[neighbor, c], dp[node, c]);
                }

                indegree[neighbor]--;
                if (indegree[neighbor] == 0) {
                    queue.Enqueue(neighbor);
                }
            }
        }

        return processed == n ? maxColorValue : -1;
    }
}