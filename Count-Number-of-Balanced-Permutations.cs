public class Solution {
    private const int MOD = 1_000_000_007;

    public int CountBalancedPermutations(string num)
    {
        int[] nums = GetNums(num);
        int sum = nums.Sum();
        if (sum % 2 == 1)
            return 0;

        Array.Sort(nums);
        Array.Reverse(nums);

        int even = (nums.Length + 1) / 2;
        int odd = nums.Length / 2;
        int evenBalance = sum / 2;

        var mem = new long?[even + 1, odd + 1, evenBalance + 1];
        long perm = GetPerm(nums);
        long result = CountBalancedPermutations(nums, even, odd, evenBalance, mem);
        return (int)((result * ModInverse(perm)) % MOD);
    }

    private long CountBalancedPermutations(int[] nums, int even, int odd, int evenBalance, long?[,,] mem)
    {
        if (evenBalance < 0)
            return 0;

        if (even == 0)
            return evenBalance == 0 ? Factorial(odd) : 0;

        int index = nums.Length - (even + odd);
        if (odd == 0)
        {
            long remainingSum = 0;
            for (int i = index; i < nums.Length; i++)
                remainingSum += nums[i];
            return remainingSum == evenBalance ? Factorial(even) : 0;
        }

        if (mem[even, odd, evenBalance].HasValue)
            return mem[even, odd, evenBalance].Value;

        long placeEven = CountBalancedPermutations(nums, even - 1, odd, evenBalance - nums[index], mem) * even % MOD;
        long placeOdd = CountBalancedPermutations(nums, even, odd - 1, evenBalance, mem) * odd % MOD;

        mem[even, odd, evenBalance] = (placeEven + placeOdd) % MOD;
        return mem[even, odd, evenBalance].Value;
    }

    private int[] GetNums(string num)
    {
        return num.Select(c => c - '0').ToArray();
    }

    private long GetPerm(int[] nums)
    {
        long res = 1;
        int[] count = new int[10];
        foreach (int digit in nums)
            count[digit]++;
        foreach (int freq in count)
            res = res * Factorial(freq) % MOD;
        return res;
    }

    private long Factorial(int n)
    {
        long res = 1;
        for (int i = 2; i <= n; i++)
            res = res * i % MOD;
        return res;
    }

    private long ModInverse(long a)
    {
        long m = MOD, y = 0, x = 1;
        while (a > 1)
        {
            long q = a / m;
            long t = m;
            m = a % m;
            a = t;
            t = y;
            y = x - q * y;
            x = t;
        }
        return x < 0 ? x + MOD : x;
    }
}