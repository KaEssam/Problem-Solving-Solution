public class Solution {
    public int MaxSubArray(int[] nums) {
        int globalMax = int.MinValue, curSum = 0;

        foreach (int num in nums) {
            curSum += num;
            globalMax = Math.Max(globalMax, curSum);
            if (curSum < 0) curSum = 0;
        }

        return globalMax;
    }
}