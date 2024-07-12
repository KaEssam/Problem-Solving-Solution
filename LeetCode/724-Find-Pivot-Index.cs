public class Solution {
    public int PivotIndex(int[] nums) {
        int sum = 0;
        int leftsum = 0;
        int n = nums.Length;
 
        for (int i = 0; i < n; ++i)
            sum += nums[i];
 
        for (int i = 0; i < n; ++i) {
 
            sum -= nums[i];
 
            if (leftsum == sum)
                return i;
 
            leftsum += nums[i];
        }
 
        return -1;
    }
}