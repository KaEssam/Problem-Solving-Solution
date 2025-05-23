public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;
        int[] ans = new int[n];
        Array.Fill(ans, 0);
        int product = 1;
        int zeros = 0;
        
        foreach (var num in nums) {
            if (num == 0) {
                zeros++;
                continue;
            }
            product *= num;
        }

        if (zeros == 1) {
            for (int i = 0; i < n; i++) {
                ans[i] = nums[i] == 0 ? product : 0;
            }
        }
        else if (zeros == 0) {
            for (int i = 0; i < n; i++) {
                ans[i] = product / nums[i];
            }
        }

        return ans;
    }
}