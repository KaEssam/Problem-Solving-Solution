public class Solution
{
    public int[] ConstructDistancedSequence(int n)
    {
        int[] res = new int[2 * n - 1];
        HashSet<int> used = new HashSet<int>();

        Backtrack(0, n, res, used);
        return res;
    }

    private bool Backtrack(int i, int n, int[] res, HashSet<int> used)
    {
        if (i == res.Length)
        {
            return true;
        }

        if (res[i] != 0)
        {
            return Backtrack(i + 1, n, res, used);
        }

        for (int num = n; num >= 1; num--)
        {
            if (used.Contains(num))
            {
                continue;
            }

            if (num > 1 && (i + num >= res.Length || res[i + num] != 0))
            {
                continue;
            }

            used.Add(num);
            res[i] = num;

            if (num > 1)
            {
                res[i + num] = num;
            }

            if (Backtrack(i + 1, n, res, used))
            {
                return true;
            }

            used.Remove(num);
            res[i] = 0;

            if (num > 1)
            {
                res[i + num] = 0;
            }
        }

        return false;
    }
}