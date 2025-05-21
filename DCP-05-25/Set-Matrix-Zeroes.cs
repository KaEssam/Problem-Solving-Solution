public class Solution {
    public void SetZeroes(int[][] matrix) {
        HashSet<int> rows = new HashSet<int>();
        HashSet<int> columns = new HashSet<int>();
        int m  = matrix.GetLength(0);
        int n = matrix[0].Length;
        for (int i = 0; i <m ; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (matrix[i][j] == 0)
                {
                    rows.Add(i);
                    columns.Add(j);
                }
            }
        }
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (rows.Contains(i) || columns.Contains(j))
                    matrix[i][j] = 0;
            }
        }
    }
}