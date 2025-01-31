public class Solution {
    
        public int LargestIsland(int[][] grid)
        {
            IList<(int row, int col)> zerosSet = new List<(int row, int col)>();
            Dictionary<int, int> mapArea = new Dictionary<int, int>();
            int result = 0;
            int currCounter = 2;
            for (int row = 0; row < grid.Length; row++)
            {
                for (int col = 0; col < grid.Length; col++)
                {
                    if (grid[row][col] == 1)
                    {
                        int areaCount = getLandAreaCount(grid, row, col, currCounter);
                        result = Math.Max(result, areaCount);
                        mapArea.Add(currCounter, areaCount);
                        currCounter++;
                    }
                    else if(grid[row][col] == 0)
                    {
                        zerosSet.Add((row, col));
                    }
                }
            }

            if (result == 0) return 1;

            foreach ((int row, int col) in zerosSet)
            {
                int cur = 1;
                HashSet<int> neighbors = new HashSet<int>();

                if (row - 1 >= 0 && grid[row - 1][col] > 0) neighbors.Add(grid[row - 1][col]);
                if (row + 1 < grid.Length && grid[row + 1][col] > 0) neighbors.Add(grid[row + 1][col]);
                if (col - 1 >= 0 && grid[row][col - 1] > 0) neighbors.Add(grid[row][col - 1]);
                if (col + 1 < grid.Length && grid[row][col + 1] > 0) neighbors.Add(grid[row][col + 1]);

                foreach (var neighbor in neighbors)
                {
                    cur += mapArea[neighbor];
                }
                result = Math.Max((int)cur, result);
            }

            return result;
        }

        private int getLandAreaCount(int[][] grid, int row, int col, int currCounter)
        {
            int count = 0;
            Queue<(int row, int col)> q = new Queue<(int, int)>();
            q.Enqueue((row, col));
            grid[row][col] = currCounter;
            while (q.Count > 0)
            {
                count++;
                var dq = q.Dequeue();

                enqueue(q, dq.row + 1, dq.col, grid, currCounter);
                enqueue(q, dq.row - 1, dq.col, grid, currCounter);
                enqueue(q, dq.row, dq.col + 1, grid, currCounter);
                enqueue(q, dq.row, dq.col - 1, grid, currCounter);

            }

            return count;
        }

        private void enqueue(Queue<(int row, int col)> q, int row, int col, int[][] grid, int currCounter)
        {
            if (row < 0 || row >= grid.Length || col < 0 || col >= grid.Length || grid[row][col] != 1) return;

            grid[row][col] = currCounter;
            q.Enqueue((row, col));
        }
       
}