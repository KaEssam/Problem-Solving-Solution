public class Solution {
    public int FindNumbers(int[] nums) => nums.
        Count(m => m.ToString().Length % 2 == 0);
}