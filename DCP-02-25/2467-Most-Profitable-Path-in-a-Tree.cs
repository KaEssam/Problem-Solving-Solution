public class Solution {
    public int MostProfitablePath(int[][] edges, int bob, int[] amount) {
        var n = edges.Length + 1;
        var graph = new (int XorSum, int Degree)[n];

        foreach (var edge in edges)
        {
            var u = edge[0];
            var v = edge[1];
            graph[u].XorSum ^= v;
            graph[u].Degree++;
            graph[v].XorSum ^= u;
            graph[v].Degree++;
        }

        var maxPendingProfit = new int[n];
        Array.Fill(maxPendingProfit, int.MinValue);

        if (graph[bob].Degree == 1)
        {
            maxPendingProfit[bob] = 0;
        }

        var prevBob = 0;
        var leafSteps = 0;
        for (var leaf = 1; leaf < n; leaf++)
        {
            if (graph[leaf].Degree != 1)
            {
                continue;
            }

            var prev = 0;
            var current = leaf;
            while (true)
            {
                if (current == bob)
                {
                    prevBob = prev;
                    break;
                }

                leafSteps++;
                var next = graph[current].XorSum ^ prev;
                maxPendingProfit[next] = int.Max(maxPendingProfit[next], amount[current]);

                if (next == 0)
                    break;

                if (graph[next].Degree > 2)
                {
                    graph[next].XorSum ^= current;
                    graph[next].Degree--;
                    break;
                }

                amount[next] += maxPendingProfit[next];
                prev = current;
                current = next;
            }
        }

        var bobDistancePlusOne = n - leafSteps;
        var halfSteps = bobDistancePlusOne >> 1;

        for (var i = 0; i < halfSteps; i++)
        {
            var nextBob = graph[bob].XorSum ^ prevBob;
            maxPendingProfit[nextBob] = int.Max(maxPendingProfit[nextBob], maxPendingProfit[bob]);
            prevBob = bob;
            bob = nextBob;
        }

        if ((bobDistancePlusOne & 1) != 0)
        {
            var nextBob = graph[bob].XorSum ^ prevBob;
            maxPendingProfit[nextBob] = int.Max(maxPendingProfit[nextBob], (amount[bob] >> 1) + maxPendingProfit[bob]);
            prevBob = bob;
            bob = nextBob;
        }

        for (var i = 0; i < halfSteps - 1; i++)
        {
            var nextBob = graph[bob].XorSum ^ prevBob;
            maxPendingProfit[nextBob] = int.Max(maxPendingProfit[nextBob], amount[bob] + maxPendingProfit[bob]);
            prevBob = bob;
            bob = nextBob;
        }

        return amount[0] + maxPendingProfit[0];
    }
}