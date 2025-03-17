public class Solution {
    public bool DivideArray(int[] nums) {
        return !nums.GroupBy(x => x).Any(x => x.Count() % 2 != 0);
    }
}