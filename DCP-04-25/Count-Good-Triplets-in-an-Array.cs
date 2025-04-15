public class Solution {
    class FenwickTree {
        private int[] tree;
        private int size;

        public FenwickTree(int n) {
            size = n;
            tree = new int[n + 2]; 
        }

        public void Update(int index, int delta) {
            index++; 
            while (index <= size + 1) {
                tree[index] += delta;
                index += index & -index;
            }
        }

        public int Query(int index) {
            index++;
            int sum = 0;
            while (index > 0) {
                sum += tree[index];
                index -= index & -index;
            }
            return sum;
        }
    }
    public long GoodTriplets(int[] nums1, int[] nums2) {
        int n = nums1.Length;

        int[] pos = new int[n];
        for (int i = 0; i < n; i++) {
            pos[nums2[i]] = i;
        }

        int[] mapped = new int[n];
        for (int i = 0; i < n; i++) {
            mapped[i] = pos[nums1[i]];
        }

        FenwickTree prefixBIT = new FenwickTree(n);
        int[] leftSmaller = new int[n];

        for (int i = 0; i < n; i++) {
            leftSmaller[i] = prefixBIT.Query(mapped[i] - 1);
            prefixBIT.Update(mapped[i], 1);
        }

        FenwickTree suffixBIT = new FenwickTree(n);
        int[] rightLarger = new int[n];

        for (int i = n - 1; i >= 0; i--) {
            rightLarger[i] = suffixBIT.Query(n - 1) - suffixBIT.Query(mapped[i]);
            suffixBIT.Update(mapped[i], 1);
        }

        long count = 0;
        for (int i = 0; i < n; i++) {
            count += (long)leftSmaller[i] * rightLarger[i];
        }

        return count;
    }
}