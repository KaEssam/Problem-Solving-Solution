public class Solution {
    public int XorAllNums(int[] nums1, int[] nums2) {
        if (nums1.Length % 2 == 0) {
            if (nums2.Length % 2 == 0)
                return 0;
            else 
                return nums1.Aggregate((s, a) => s ^ a);
        }    

        if (nums2.Length % 2 == 0)
            return nums2.Aggregate((s, a) => s ^ a);

        return nums1.Concat(nums2).Aggregate((s, a) => s ^ a);
    }
}