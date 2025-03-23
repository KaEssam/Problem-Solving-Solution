using System;
using System.Collections.Generic;

public class Solution {
    public int CountPaths(int n, int[][] roads) {
        int mod = 1_000_000_007;
        var adj = new List<(int, int)>[n];
        for (int i = 0; i < n; i++) adj[i] = new List<(int, int)>();

        foreach (var road in roads) {
            adj[road[0]].Add((road[1], road[2]));
            adj[road[1]].Add((road[0], road[2]));
        }

        long[] shortestTime = new long[n];
        Array.Fill(shortestTime, long.MaxValue);
        int[] cnt = new int[n];
        var pq = new SortedSet<(long, int)> { (0, 0) };

        shortestTime[0] = 0;
        cnt[0] = 1;

        while (pq.Count > 0) {
            var (time, node) = pq.Min;
            pq.Remove(pq.Min);

            if (time > shortestTime[node]) continue;

            foreach (var (nbr, rtime) in adj[node]) {
                if (time + rtime < shortestTime[nbr]) {
                    pq.Remove((shortestTime[nbr], nbr));
                    shortestTime[nbr] = time + rtime;
                    cnt[nbr] = cnt[node];
                    pq.Add((shortestTime[nbr], nbr));
                }
                else if (time + rtime == shortestTime[nbr]) {
                    cnt[nbr] = (cnt[nbr] + cnt[node]) % mod;
                }
            }
        }

        return cnt[n - 1];
    }
}