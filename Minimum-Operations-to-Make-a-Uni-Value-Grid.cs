public class Solution {
    public int MinOperations(int[][] grid, int x) {
        int rem = grid[0][0] % x, max = 0, min = 10000;
        int[] med = new int[10000];

        foreach(int[] arr in grid){
            foreach(int n in arr){
                if(n % x != rem) return -1;
                max = Math.Max(max, n);
                min = Math.Min(min, n);
                ++med[n-1];
            }
        }

        int mid = 0, ans = 0, pm = (grid.Length*grid[0].Length)/2+1;
        
        for(int i=min-1; i!=max; ++i){
            while(pm!=0 && med[i]!=0){
                --pm;
                --med[i];
            }
            if(pm==0){
                mid = i+1;
                break;
            }
        }

        foreach(int[] arr in grid){
            foreach(int n in arr){
                ans += (int)Math.Abs(n-mid) / x;
            }
        }

        return grid.Length==1 && grid[0].Length==1?0:ans;
    }
}