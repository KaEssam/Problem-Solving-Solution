public class Solution {
         public int MaxAbsoluteSum(int[] nums) {
        int minsum=0,maxsum=0,currmin=0,currmax=0;
        foreach (int num in nums)
        {
             currmax=Math.Max(num,currmax+num);
             maxsum=Math.Max(maxsum,currmax);
              currmin=Math.Min(num,currmin+num);
              minsum=Math.Min(minsum,currmin); 
        }
        return Math.Max(maxsum,Math.Abs(minsum));   
    }
}