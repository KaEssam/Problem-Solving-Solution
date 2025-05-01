using System;
using System.Collections.Generic;

public class Solution
{
    private int[] tasks;
    private int[] workers;
    private int strength;
    private int pills;
    private int m;
    private int n;

    public int MaxTaskAssign(int[] tasks, int[] workers, int pills, int strength)
    {
        Array.Sort(tasks);
        Array.Sort(workers);
        this.tasks = tasks;
        this.workers = workers;
        this.strength = strength;
        this.pills = pills;
        this.n = tasks.Length;
        this.m = workers.Length;

        int left = 0, right = Math.Min(m, n);
        while (left < right)
        {
            int mid = (left + right + 1) >> 1;
            if (Check(mid))
            {
                left = mid;
            }
            else
            {
                right = mid - 1;
            }
        }
        return left;
    }

    private bool Check(int x)
    {
        int i = 0;
        LinkedList<int> deque = new LinkedList<int>();
        int p = pills;

        for (int j = m - x; j < m; ++j)
        {
            while (i < x && tasks[i] <= workers[j] + strength)
            {
                deque.AddLast(tasks[i++]);
            }

            if (deque.Count == 0)
                return false;

            if (deque.First.Value <= workers[j])
            {
                deque.RemoveFirst();
            }
            else if (p == 0)
            {
                return false;
            }
            else
            {
                --p;
                deque.RemoveLast();
            }
        }

        return true;
    }
}