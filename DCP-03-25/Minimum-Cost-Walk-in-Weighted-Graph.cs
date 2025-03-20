using System;
using System.Linq;

public class Solution
{
    private static readonly int NO_PATH_FOUND = -1;

    public int[] MinimumCost(int numberOfNodes, int[][] edges, int[][] queries)
    {
        UnionFind unionFind = new UnionFind(numberOfNodes);
        int[] minCostToReachParent = CreateMinCostToReachParent(unionFind, numberOfNodes, edges);
        return CreateMinCostPerQuery(unionFind, minCostToReachParent, queries);
    }

    private int[] CreateMinCostToReachParent(UnionFind unionFind, int numberOfNodes, int[][] edges)
    {
        int[] minCostToReachParent = new int[numberOfNodes];
        Array.Fill(minCostToReachParent, int.MaxValue);

        foreach (int[] edge in edges)
        {
            int parentFirst = unionFind.FindParent(edge[0]);
            int parentSecond = unionFind.FindParent(edge[1]);
            int cost = edge[2];

            minCostToReachParent[parentFirst] &= cost & minCostToReachParent[parentSecond];
            minCostToReachParent[parentSecond] &= cost & minCostToReachParent[parentFirst];

            if (parentFirst != parentSecond)
            {
                unionFind.JoinByRank(parentFirst, parentSecond);
            }
        }
        return minCostToReachParent;
    }

    private int[] CreateMinCostPerQuery(UnionFind unionFind, int[] minCostToReachParent, int[][] queries)
    {
        int[] minCostPerQuery = new int[queries.Length];

        for (int i = 0; i < queries.Length; ++i)
        {
            int parentFirst = unionFind.FindParent(queries[i][0]);
            int parentSecond = unionFind.FindParent(queries[i][1]);

            if (parentFirst != parentSecond)
            {
                minCostPerQuery[i] = NO_PATH_FOUND;
            }
            else
            {
                minCostPerQuery[i] = minCostToReachParent[parentFirst];
            }
        }

        return minCostPerQuery;
    }
}

class UnionFind
{
    private readonly int[] rank;
    private readonly int[] parent;

    public UnionFind(int numberOfNodes)
    {
        rank = new int[numberOfNodes];
        parent = new int[numberOfNodes];

        for (int node = 0; node < numberOfNodes; ++node)
        {
            parent[node] = node;
        }
    }

    public int FindParent(int node)
    {
        while (parent[node] != node)
        {
            node = parent[node];
        }
        return parent[node];
    }

    public void JoinByRank(int firstNode, int secondNode)
    {
        if (rank[firstNode] >= rank[secondNode])
        {
            parent[secondNode] = firstNode;
            rank[firstNode] += rank[secondNode] + 1;
        }
        else
        {
            parent[firstNode] = secondNode;
            rank[secondNode] += rank[firstNode] + 1;
        }
    }
}