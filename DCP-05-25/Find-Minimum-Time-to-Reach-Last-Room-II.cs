using System;
using System.Collections.Generic;

public class Solution {
    public int MinTimeToReach(int[][] moveTime) {
        int n = moveTime.Length, m = moveTime[0].Length;
        var dp = new int[n][];
        for (int i = 0; i < n; i++) {
            dp[i] = new int[m];
            Array.Fill(dp[i], int.MaxValue);
        }

        var pq = new PriorityQueue<(int time, int r, int c), int>();
        pq.Enqueue((0, 0, 0), 0);

        int[][] dirs = new int[][] { new[]{1,0}, new[]{0,1}, new[]{-1,0}, new[]{0,-1} };

        while (pq.Count > 0) {
            var (time, r, c) = pq.Dequeue();
            if (time >= dp[r][c]) continue;
            dp[r][c] = time;
            if (r == n - 1 && c == m - 1) return time;

            foreach (var dir in dirs) {
                int nr = r + dir[0], nc = c + dir[1];
                if (nr >= 0 && nr < n && nc >= 0 && nc < m) {
                    int cost = (r + c) % 2 + 1;
                    int wait = Math.Max(time, moveTime[nr][nc]);
                    int total = wait + cost;
                    if (total < dp[nr][nc]) {
                        pq.Enqueue((total, nr, nc), total);
                    }
                }
            }
        }

        return -1;
    }
}