public class Solution {
    public int FindDuplicate(int[] nums) {
        bool []boolarr = new bool[nums.Length]; 
        for(int i = 0; i < nums.Length; i++){
              if(boolarr[nums[i]]) 
                    return nums[i];
              boolarr[nums[i]] = true;
        }
        return -1;
    }
}