public class Solution {
    public long CountBadPairs(int[] nums) {
        int n = nums.Length;
        long totalPairs = (long)n * (n - 1) / 2; 
        Dictionary<int, int> freqMap = new Dictionary<int, int>();
        long goodPairs = 0;

        for (int i = 0; i < n; i++) {
            int diff = nums[i] - i;
            if (freqMap.ContainsKey(diff)) {
                goodPairs += freqMap[diff]; 
                freqMap[diff]++;
            } else {
                freqMap[diff] = 1;
            }
        }

        return totalPairs - goodPairs;
    }
}