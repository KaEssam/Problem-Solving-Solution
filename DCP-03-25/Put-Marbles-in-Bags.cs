
public class Solution {
    public int[] ApplyOperations(int[] nums) {
        int n = nums.Length;
        int[] newNums = new int[n]; 
        int count = 0;

        for (int i = 0; i < n - 1; i++) {
            if (nums[i] != 0) {
                if (nums[i] == nums[i + 1]) {
                    newNums[count] = nums[i] * 2; 
                    nums[i + 1] = 0; 
                    i++; 
                } else {
                    newNums[count] = nums[i]; 
                }
                count++; 
            }
        }
        if (nums[n - 1] != 0) {
            newNums[count++] = nums[n - 1];
        }

        return newNums;
    }
}