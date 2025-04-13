using System;

public class Solution {
    const long MOD = 1000000007;

    long Helper(long n, long k) {
        if (k == 0) return 1;
        if (k % 2 == 0) {
            long ans = Helper(n, k / 2) % MOD;
            return (ans * ans) % MOD;
        }
        return (Helper(n, k - 1) * n) % MOD;
    }

    public int CountGoodNumbers(long n) {
        long even = n / 2;
        if (n % 2 == 0)
            return (int)((Helper(5, even) * Helper(4, even)) % MOD);
        return (int)((Helper(5, even + 1) * Helper(4, even)) % MOD);
    }
}