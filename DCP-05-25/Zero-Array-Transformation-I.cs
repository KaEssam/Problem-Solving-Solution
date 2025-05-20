public class Solution {
    public bool IsZeroArray(int[] nums, int[][] queries) {
        int[] pref = new int[nums.Length+1];
        foreach(int[] query in queries)
            {pref[query[0]]++; pref[query[1]+1]--;}
        int diff = pref[0];
        for(int i=0; i<nums.Length; diff += pref[++i])
            if(nums[i]>diff)
                return false;
        return true;
    }
}