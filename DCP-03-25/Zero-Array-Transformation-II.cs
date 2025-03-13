public class Solution {
    public int MinZeroArray(int[] nums, int[][] queries) {
        int n = nums.Length;
        
        bool CanMakeZeroArray(int k) {
            int[] diff = new int[n + 1];
            for (int i = 0; i < k; i++) {
                int left = queries[i][0], right = queries[i][1], val = queries[i][2];
                diff[left] += val;
                diff[right + 1] -= val;
            }
            int currVal = 0;
            for (int i = 0; i < n; i++) {
                currVal += diff[i];
                if (currVal < nums[i]) return false;
            }
            return true;
        }
        
        if (nums.All(x => x == 0)) return 0;
        int left = 1, right = queries.Length;
        if (!CanMakeZeroArray(right)) return -1;
        while (left < right) {
            int mid = left + (right - left) / 2;
            if (CanMakeZeroArray(mid)) right = mid;
            else left = mid + 1;
        }
        return left;
    }
}