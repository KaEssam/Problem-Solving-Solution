public class Solution {
    public int TrapRainWater(int[][] heightMap) {
        if(heightMap==null || heightMap.Length==0 || heightMap[0].Length==0) return 0;
        int X = heightMap.Length;
        int Y = heightMap[0].Length;
        int[][] heights = new int[X][];
        for(int i = 0; i< X; i++)
        {
            heights[i] = new int[Y];
        }
        int result = 0;
        int lastResult = 1;
        while(lastResult!=result)
        {
            for(int i = 1; i< X-1; i++)
            {
                for(int j = 1; j < Y-1; j++)
                {
                    int height = Math.Min(Math.Max(heightMap[i-1][j], heights[i-1][j]),Math.Max(heightMap[i][j-1],heights[i][j-1]));
                    heights[i][j] =heights[i][j]==0?height:Math.Min(heights[i][j], height);
                }
            }
        
            for(int i = X-2; i>=1; i--)
            {
                for(int j = Y-2; j>=1; j--)
                {
                    int height = Math.Min(Math.Max(heightMap[i+1][j], heights[i+1][j]),Math.Max(heightMap[i][j+1],heights[i][j+1]));
                    heights[i][j] = Math.Min(heights[i][j], height);
                }
            }
            int sum = 0;
            for(int i = 1; i< X-1; i++)
            {
                for(int j = 1; j< Y-1; j++)
                {
                    if(heights[i][j]>heightMap[i][j])
                        sum+=(heights[i][j]-heightMap[i][j]);
                }
            }
            result = lastResult;
            lastResult = sum;
        }
        return result;
    }
}