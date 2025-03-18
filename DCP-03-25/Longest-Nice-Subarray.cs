public class Solution {
    public int LongestNiceSubarray(int[] nums)
    {
        int left = 0, right = 1;
        int count = nums.Length;

        if (count == 0) return 0;
        if (count == 1) return 1;

        int max = 1;

        while (right < count)
        {
            if (CheckNiceArray2(left, right, nums))
            {
                if (right - left >= max) max = right - left + 1;
                
                right++;
            }
            else
            {
                for (int i = right - 1; i > left; i--)
                {
                    if (!CheckNiceArray2(i, right, nums))
                    {
                        left = i;
                        right++;
                        break;
                    }
                }

                left++;
                if (left == right) right++;
            }
        }

        return max;
    }

    bool CheckNiceArray2(int left, int right, int[] nums)
    {
        for (int i = left; i < right; i++)
        {
            if ( ( nums[i] & nums[right] ) != 0) return false;
        }

        return true;
    }
}