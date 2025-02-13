public class Solution {
    public int MinOperations(int[] nums, int k) {
        int result = 0;
        List<long> newNums = new List<long>();
        Array.Sort(nums, (a, b) => b.CompareTo(a));
        int i = nums.Length-1; 
        int j = 0; 
        while(true){
            long a,b;
            if(newNums.Count > 0 && j < newNums.Count && (i < 0 || newNums[j] < nums[i] ))
                a = newNums[j++];
            else
                a = nums[i--];
            if( a >= k)
                return result;
            if(newNums.Count > 0 && j < newNums.Count && (i < 0 || newNums[j] < nums[i]  ))
                b = newNums[j++];
            else
                b = nums[i--];
            newNums.Add( a*2 + b);
            result++;

        }
        return result;
    }
}