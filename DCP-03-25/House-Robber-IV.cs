public class Solution {
    private bool CanStealKHouses(int[] nums, int k, int capability) {
        int count = 0;
        int i = 0;
        while (i < nums.Length) {
            if (nums[i] <= capability) {
                count++;
                i += 2;
            } else {
                i++;
            }
        }
        return count >= k;
    }
    
    public int MinCapability(int[] nums, int k) {
        int left = nums.Min();
        int right = nums.Max();
        
        while (left < right) {
            int mid = left + (right - left) / 2;
            if (CanStealKHouses(nums, k, mid)) {
                right = mid;
            } else {
                left = mid + 1;
            }
        }
        
        return left;
    }
}