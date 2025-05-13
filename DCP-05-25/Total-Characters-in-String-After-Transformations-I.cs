public class Solution {
    public int LengthAfterTransformations(string s, int t) {
        int p = 1_000_000_007;
        int n = s.Length;
        int[] counts = new int[26];
        for (int i = 0; i < n; i++)
        {
            counts[s[i] - 'a']++;
        }
        int next = 0;
        for (int i = 0; i < t; i++)
        {
            counts[next] += counts[(next + 25) % 26];
            counts[next] %= p;
            next = (next + 25) % 26;
        }
        int result = 0;
        for (int i = 0; i < 26; i++)
        {
            result += counts[i];
            result %= p;
        }
        return result;
    }
}