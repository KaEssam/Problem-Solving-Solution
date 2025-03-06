using System;
using System.Linq;

public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
        int n = grid.Length;
        int[] fre = new int[n * n + 1];

        foreach (var row in grid) {
            foreach (var num in row)
                fre[num]++;
        }

        int rep = 0, mis = 0;
        for (int j = 1; j < fre.Length; j++) {
            if (fre[j] == 0)
                mis = j;
            if (fre[j] == 2)
                rep = j;
        }

        return new int[]{rep, mis};
    }
}