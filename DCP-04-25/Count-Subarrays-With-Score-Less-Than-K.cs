public class Solution {
    public long CountSubarrays(int[] nums, long k) {
    int n = nums.Length, i = 0;
    long sum = 0, cnt = 0;
    for (int j = 0; j < n; j++) {
        sum += nums[j];
        while (i <= j && sum * (j - i + 1) >= k) {
            sum -= nums[i++];
        }
        cnt += (j - i + 1);
    }
    return cnt;
}
}