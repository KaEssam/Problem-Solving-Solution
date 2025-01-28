public class Solution {
    public int FindMaxFish(int[][] grid) {
        int n = grid.Length, m = grid[0].Length;
        int[] dx = {-1, 0, 1, 0};
        int[] dy = {0, 1, 0, -1};

        int Dfs(int x, int y) {
            if (x < 0 || x >= n || y < 0 || y >= m || grid[x][y] == 0) return 0;

            int fish = grid[x][y];
            grid[x][y] = 0;

            for (int d = 0; d < 4; d++) {
                fish += Dfs(x + dx[d], y + dy[d]);
            }
            return fish;
        }

        int maxFish = 0;
        for (int i = 0; i < n; i++) {
            for (int j = 0; j < m; j++) {
                if (grid[i][j] > 0) {
                    maxFish = Math.Max(maxFish, Dfs(i, j));
                }
            }
        }
        return maxFish;
    }
}