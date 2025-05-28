public class Solution {
    public int LongestMonotonicSubarray(int[] nums) {
        int max = 1;

        int dec = 1; int inc = 1;
        for(int i=1; i < nums.Length; i++){
            if (nums[i] > nums[i-1]) { inc++; dec = 1;}

            if (nums[i] < nums[i-1]) { dec++; inc = 1;}

            max = Math.Max(max, Math.Max(inc, dec)); 

            if (nums[i] == nums[i-1])  { dec = 1; inc = 1;}
        }

        return max;
    }
}