public class Solution {
    public int NumberOfAlternatingGroups(int[] colors, int k) {
        int i=0,j=1,n=colors.Length,len=n+k-1,ans=0,lastBad=-1;
        bool windowHit=false;
        while(j<len)
        {
            if(colors[j%n]==colors[(j-1)%n])
            {
                lastBad=j-1;
            }

            if(j-i+1==k )
            {
                if(lastBad<i)
                {
                    ans++;
                }
                i++;
            }
            
            j++;
        }
        return ans;
    }
}