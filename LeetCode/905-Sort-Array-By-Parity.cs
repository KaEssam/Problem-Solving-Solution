public class Solution {
    public int[] SortArrayByParity(int[] nums) {

        int[] result = new int[nums.Length];
        int even = 0;
        int odd = nums.Length - 1;

        foreach(var num in nums){
            if(num % 2 == 0 ){
            result[even]=num;
            even++;

            }else{
            result[odd]=num;
            odd--;
            }
        }
        return result;
    }
}