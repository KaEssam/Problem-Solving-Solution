public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int n = nums.Length;
        int[] Ans = new int[n * 2];

        for (int i = 0; i < n; i++)
        {
            Ans[i] = Ans[n + i] = nums[i];
        }
        return Ans;
    }
}