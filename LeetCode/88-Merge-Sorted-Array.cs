public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        for (int j = 0, i = m; j<n; j++){
            nums1[i] = nums2[j];
            i++;
        }
        Array.Sort(nums1);
    }
}