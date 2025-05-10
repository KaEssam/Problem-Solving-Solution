public class Solution
{
    public long MinSum(int[] nums1, int[] nums2)
    {
        var sum1 = nums1.Aggregate(0L, (current, n) => current + n);
        var count1 = nums1.Count(x => x == 0);
        
        var sum2 = nums2.Aggregate(0L, (current, n) => current + n);
        var count2 = nums2.Count(x => x == 0);

        if (count1 == 0 && count2 == 0 && sum1 != sum2)
            return -1;

        if (count1 == 0 && sum1 < sum2 + count2)
            return -1;
        
        if (count2 == 0 && sum2 < sum1 + count1)
            return -1;
        
        return Math.Max(sum1 + count1, sum2 + count2);
    }
}