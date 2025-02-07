public class Solution
{
    public int[] QueryResults(int limit, int[][] q)
    {
        var results = new int[q.Length];

        var ballsToColors = new Dictionary<int, int>(q.Length);
        var colorsToCount = new Dictionary<int, int>(q.Length);
        var colorsCount = 0;

        for (var i = 0; i < q.Length; i++)
        {
            if (ballsToColors.TryGetValue(q[i][0], out var color) && color != q[i][1])
            {
                if (colorsToCount[color] == 1)
                {
                    colorsToCount.Remove(color);
                    colorsCount--;
                }
                else colorsToCount[color]--;
            }
            else if (color == q[i][1])
            {
                results[i] = colorsCount;
                continue;
            }

            if (colorsToCount.TryAdd(q[i][1], 1)) colorsCount++;
            else colorsToCount[q[i][1]]++;

            if (!ballsToColors.TryAdd(q[i][0], q[i][1]))
            {
                ballsToColors[q[i][0]] = q[i][1];
            }

            results[i] = colorsCount;
        }

        return results;
    }
}