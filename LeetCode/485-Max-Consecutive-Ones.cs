public class Solution {
    public int FindMaxConsecutiveOnes(int[] nums) {
        int MaxConsecutive = 0;
        int sum = 0;
        
        for(int i = 0; i < nums.Length; i++){
            
            if(nums[i] == 0){
                sum=0;
            }else{
                sum++;
                MaxConsecutive = Math.Max(MaxConsecutive,sum);    
            }
        }
         return MaxConsecutive;

    }
}