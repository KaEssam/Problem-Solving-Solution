public class Solution {
    public int MaxAscendingSum(int[] nums) {
        int n = nums.Length;
        int maxSum = 0;

        for (int i = 0; i < n; i++) {
            int currentSum = nums[i];

            for (int j = i + 1; j < n && nums[j] > nums[j - 1]; j++) {
                currentSum += nums[j]; 
                i = j; 
            }

            maxSum = Math.Max(maxSum, currentSum); 
        }

        return maxSum;
    }
}