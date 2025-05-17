public class Solution {
    public void SortColors(int[] nums) {
        int low =0;
        int mid =0;
        int high =nums.Length-1;

        while(high >= mid){
            if(nums[mid] == 0){
                int temp = nums[mid];
                nums[mid] = nums[low];
                nums[low] = temp;
                mid++;
                low++;
                continue;
            }
            else if(nums[mid] == 1){
                mid++;
                continue;
            }
            else{
                int temp = nums[mid];
                nums[mid] = nums[high];
                nums[high] = temp;
                high--;
            }
            
        }
    }
}