public class Solution 
{
    public int[][] HighestPeak(int[][] isWater) 
    {
        int m = isWater.Length;
        int n = isWater[0].Length;
        int[][] dis = new int[m][];
        
        for(int i=0;i<m;i++)
            dis[i] = new int[n];
        
        Queue<(int x,int y)> qu = new Queue<(int x,int y)>();
        
        for(int i=0; i<m; i++)
        {
            for(int j=0; j<n; j++)
            {
                if(isWater[i][j]==1)
                    qu.Enqueue((i,j));
                else
                    dis[i][j]=-1;
            }
        }
        
        int[] dx = {-1,1,0,0};
        int[] dy = {0,0,-1,1};
        
        while(qu.Count>0)
        {
            int cnt = qu.Count;
            
            for(int i=0;i<cnt;i++)
            {
                var cur = qu.Dequeue();
                
                for(int d=0;d<4;d++)
                {
                    int a = cur.x + dx[d];
                    int b = cur.y + dy[d];
                    
                    if(a<0 || a>=m || b<0 || b>=n || dis[a][b]!=-1)
                        continue;
                    
                    dis[a][b] = dis[cur.x][cur.y] + 1;
                    qu.Enqueue((a,b));
                }
            }
        }
        
        return dis;
    }
}