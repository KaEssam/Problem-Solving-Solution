public class Solution {
    public long MaximumTripletValue(int[] nums) {
          long val = 0; long max = 0;
  for (int i = 0; i < nums.Length; i++)
  {
      for (int j = i + 1; j < nums.Length; j++)
      {
          if (nums[i] > nums[j])
          {
              for (int k = j + 1; k < nums.Length; k++)
              {
                  long sub = nums[i] - nums[j];
                  long m = sub * nums[k];
                  val = (long)m;
                  if (val > max)
                  {
                      max = val;
                  }
                  Console.WriteLine(max);
              }
          }
      }
  }
  return max;
    }
}