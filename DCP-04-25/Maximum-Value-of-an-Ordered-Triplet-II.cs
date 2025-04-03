public class Solution
{
    public long MaximumTripletValue(int[] nums)
    {
        int len = nums.Length;
        long[] maxFromLeft = new long[len];
        long[] maxFromRight = new long[len];
        long ans = 0;

        maxFromLeft[0] = nums[0];
        maxFromRight[len - 1] = nums[len - 1];
        for (int i = 1; i < len; i++)
        {
            maxFromLeft[i] = Math.Max(maxFromLeft[i - 1], nums[i]);
            maxFromRight[len - i - 1] = Math.Max(maxFromRight[len - i], nums[len - i - 1]);
        }
        for (int i = 1; i < len - 1; i++)
        {
            ans = Math.Max(ans, (maxFromLeft[i - 1] - nums[i]) * maxFromRight[i + 1]);
        }
        return ans;
    }
}