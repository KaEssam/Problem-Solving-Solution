public class Solution {
    public int SnakesAndLadders(int[][] board) {
        int n = board.Length;
        int[] flattened = new int[n * n + 1]; 
        bool leftToRight = true;
        int index = 1;

        for (int i = n - 1; i >= 0; i--) {
            if (leftToRight) {
                for (int j = 0; j < n; j++) {
                    flattened[index++] = board[i][j];
                }
            } else {
                for (int j = n - 1; j >= 0; j--) {
                    flattened[index++] = board[i][j];
                }
            }
            leftToRight = !leftToRight;
        }

        Queue<int> queue = new Queue<int>();
        bool[] visited = new bool[n * n + 1];
        queue.Enqueue(1);
        visited[1] = true;
        int moves = 0;

        while (queue.Count > 0) {
            int size = queue.Count;
            moves++;
            for (int i = 0; i < size; i++) {
                int curr = queue.Dequeue();

                for (int dice = 1; dice <= 6; dice++) {
                    int next = curr + dice;
                    if (next > n * n) break;

                    if (flattened[next] != -1) {
                        next = flattened[next];
                    }

                    if (next == n * n) {
                        return moves;
                    }

                    if (!visited[next]) {
                        visited[next] = true;
                        queue.Enqueue(next);
                    }
                }
            }
        }

        return -1;
    }
}