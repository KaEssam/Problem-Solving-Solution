public class Solution
{
    public int MaximumSum(int[] nums)
    {
        Dictionary<int, int> maxByDigitSum = new();
        int res = -1;

        foreach (int num in nums)
        {
            int digitSum = GetDigitSum(num);

            if (maxByDigitSum.TryGetValue(digitSum, out int maxNum))
            {
                res = Math.Max(res, maxNum + num);
                maxByDigitSum[digitSum] = Math.Max(maxNum, num);
            }
            else
            {
                maxByDigitSum[digitSum] = num;
            }
        }

        return res;
    }

    private static int GetDigitSum(int num)
    {
        int sum = 0;
        while (num != 0)
        {
            sum += num % 10;
            num /= 10;
        }
        return sum;
    }
}