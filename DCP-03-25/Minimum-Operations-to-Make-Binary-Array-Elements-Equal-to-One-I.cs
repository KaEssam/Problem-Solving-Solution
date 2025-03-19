public class Solution {
    public int MinOperations(int[] nums) {
        int res = 0;
        int n = nums.Length;

        for (int i = 0; i < n - 2; ++i) {
            if (nums[i] == 0) {
                nums[i] = 1;
                nums[i + 1] = nums[i + 1] == 1 ? 0 : 1;
                nums[i + 2] = nums[i + 2] == 1 ? 0 : 1;
                ++res;
            }
        }

        return nums[n - 1] == 1 && nums[n - 2] == 1 ? res : -1;
    }
}