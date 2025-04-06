
public class Solution {
    List<int> res;
    int[] mem;

    public List<int> LargestDivisibleSubset(int[] nums) {
        Array.Sort(nums);
        res = new List<int>();
        mem = new int[nums.Length];
        Array.Fill(mem, -1);
        Helper(nums, 0, new List<int>(), 1);
        return res;
    }

    private void Helper(int[] nums, int index, List<int> curr, int prev) {
        if(curr.Count > res.Count) {
            res = new List<int>(curr);
        }

        for(int i = index; i < nums.Length; i++) {
            if(curr.Count > mem[i] && nums[i] % prev == 0) {
                mem[i] = curr.Count;
                curr.Add(nums[i]);
                Helper(nums, i + 1, curr, nums[i]);
                curr.RemoveAt(curr.Count - 1);
            }
        }
    }
}