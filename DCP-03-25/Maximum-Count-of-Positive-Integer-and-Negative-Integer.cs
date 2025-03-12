public class Solution {
    public int MaximumCount(int[] nums) {
        int negCount = BinarySearch(nums, 0);
        int posCount = nums.Length - BinarySearch(nums, 1);
        return Math.Max(negCount, posCount);
    }

    private int BinarySearch(int[] nums, int target) {
        int left = 0, right = nums.Length - 1, result = nums.Length;
        
        while (left <= right) {
            int mid = (left + right) / 2;
            if (nums[mid] < target) {
                left = mid + 1;
            } else {
                result = mid;
                right = mid - 1;
            }
        }
        
        return result;
    }
}