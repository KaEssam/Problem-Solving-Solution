using System;
using System.Collections.Generic;

public class Solution {
    public int SubarraySum(int[] nums, int k) {
        Dictionary<int, int> mp = new Dictionary<int, int>(); 
        mp[0] = 1;

        int preSum = 0, cnt = 0;
        foreach(int num in nums) {
            preSum += num;
            if(mp.ContainsKey(preSum - k)){
                cnt += mp[preSum - k];
            }
            if(mp.ContainsKey(preSum)) {
                mp[preSum]++;
            } else {
                mp[preSum] = 1;
            }
        }
        return cnt;
    }
}