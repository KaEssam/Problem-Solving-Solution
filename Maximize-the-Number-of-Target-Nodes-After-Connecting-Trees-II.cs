public class Solution {
    public int[] MaxTargetNodes(int[][] edges1, int[][] edges2) {
        int n = edges1.Length + 1, m = edges2.Length + 1;
        int[] color1 = new int[n];
        int[] color2 = new int[m];
        int[] count1 = Build(edges1, color1);
        int[] count2 = Build(edges2, color2);
        int[] res = new int[n];
        for (int i = 0; i < n; i++) {
            res[i] = count1[color1[i]] + Math.Max(count2[0], count2[1]);
        }
        return res;
    }

    private int[] Build(int[][] edges, int[] color) {
        int n = edges.Length + 1;
        List<int>[] children = new List<int>[n];
        for (int i = 0; i < n; i++) {
            children[i] = new List<int>();
        }
        foreach (var edge in edges) {
            children[edge[0]].Add(edge[1]);
            children[edge[1]].Add(edge[0]);
        }
        int res = Dfs(0, -1, 0, children, color);
        return new int[] { res, n - res };
    }

    private int Dfs(int node, int parent, int depth, List<int>[] children,
                    int[] color) {
        int res = 1 - depth % 2;
        color[node] = depth % 2;
        foreach (int child in children[node]) {
            if (child == parent) {
                continue;
            }
            res += Dfs(child, node, depth + 1, children, color);
        }
        return res;
    }
}