public class Solution {
    public int RemoveDuplicates(int[] nums) {


        //idea: remove the duplicate from array

        //approch: 
        //1-check duplicate, if duplicate remove, else add to new array
        //2- print new array
        
        int expectedNums = 0;

        for(int i =1; i < nums.Length; i++){
            if(nums[expectedNums] != nums[i]){
                nums[++expectedNums] = nums[i];
            }
        }
        return expectedNums+1;
        
        
    }
}