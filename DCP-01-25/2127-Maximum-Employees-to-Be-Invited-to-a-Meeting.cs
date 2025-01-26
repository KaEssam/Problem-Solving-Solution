public class Solution {
    public int MaximumInvitations(int[] favorite) {
        int n = favorite.Length;
        int[] indegree = new int[n];
        int[] chainLength = new int[n];
        bool[] visited = new bool[n];

        foreach (int f in favorite) {
            indegree[f]++;
        }

        Queue<int> queue = new Queue<int>();
        for (int i = 0; i < n; i++) {
            if (indegree[i] == 0) {
                queue.Enqueue(i);
            }
        }

        while (queue.Count > 0) {
            int curr = queue.Dequeue();
            int fav = favorite[curr];
            chainLength[fav] = Math.Max(chainLength[fav], chainLength[curr] + 1);
            indegree[fav]--;
            if (indegree[fav] == 0) {
                queue.Enqueue(fav);
            }
        }
        int maxCycleLength = 0;
        int chainPairsLength = 0;

        for (int i = 0; i < n; i++) {
            if (!visited[i] && indegree[i] > 0) {
                int cycleLength = 0;
                int curr = i;
                do {
                    visited[curr] = true;
                    curr = favorite[curr];
                    cycleLength++;
                } while (curr != i);

                if (cycleLength == 2) {
                    int a = i, b = favorite[i];
                    chainPairsLength += 2 + chainLength[a] + chainLength[b];
                } else {
                    maxCycleLength = Math.Max(maxCycleLength, cycleLength);
                }
            }
        }

        return Math.Max(maxCycleLength, chainPairsLength);
    }
}