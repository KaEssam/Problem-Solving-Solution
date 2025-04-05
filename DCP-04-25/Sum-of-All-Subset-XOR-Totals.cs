public class Solution {
    public int SubsetXORSum(int[] nums) {
        return Subsets(nums, 0, 0);
    }

    private int Subsets(int[] nums, int i, int curr) {
        if (i >= nums.Length) {
            return curr;
        }
        return Subsets(nums, i + 1, nums[i] ^ curr) + Subsets(nums, i + 1, curr);
    }
}