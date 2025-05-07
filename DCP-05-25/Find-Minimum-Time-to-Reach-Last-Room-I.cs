public class Solution {
    static int[][] directions = [[0,1],[0,-1],[1,0],[-1,0]];
    public int MinTimeToReach(int[][] moveTime) {
        int rows = moveTime.Length, cols = moveTime[0].Length;
        PriorityQueue<int[],int> minPQ = new();
        minPQ.Enqueue([0,0],0);     

        int[,] lastVisitedTime = new int[rows,cols];
        for(int r=0;r<rows;r++)
            for(int c=0;c<cols;c++)
                lastVisitedTime[r,c] = int.MaxValue;
        lastVisitedTime[0,0] = 0;
        
        while(minPQ.TryDequeue(out var cell, out int time))
            if(cell[0]==rows-1 && cell[1]==cols-1)
                return time;
            else
                foreach(var d in directions)
                {
                    int r1 = cell[0]+d[0];
                    int c1 = cell[1]+d[1];
                    if(r1>=0 && r1<rows && c1>=0 && c1<cols && Math.Max(time,moveTime[r1][c1]) < lastVisitedTime[r1,c1]-1)    
                    {
                        int newTime = 1 + Math.Max(time,moveTime[r1][c1]);
                        lastVisitedTime[r1,c1] = newTime;
                        minPQ.Enqueue([r1,c1],newTime);
                    }
                }
        return -1;
    }
}