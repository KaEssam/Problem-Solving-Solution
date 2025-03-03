public class Solution {
    public int[] PivotArray(int[] nums, int pivot) {
        
            List<int > list = new List<int>();
            int l= nums.Length;
            int start = 0;
            int index = 0;
            int equal = 0;
            for (int i = 0; i < l; i++)
            {
                if(pivot< nums[i])
                    list.Add(nums[i]);

                else if(pivot == nums[i])
                    equal++;

                else
                {
                    nums[index] = nums[i];
                    index++;
                }
            }
            for (int i = index; i < l; i++)
            {
                if(equal!= 0)
                {
                    --equal;
                    nums[i] = pivot;
                }
                else
                {
                    nums[i] = list[start];
                    start++;
                }
            }
            return nums;
    }
}