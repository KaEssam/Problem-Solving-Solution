public class Solution {
    public IList<string> GetWordsInLongestSubsequence(string[] words, int[] groups) {
        int n = words.Length;
        long[] codes = new long[n];
        for (int i = 0; i < n; i++) {
            long code = 0;
            var w = words[i];
            for (int j = 0; j < w.Length; j++) {
                code |= (long)(w[j] - 'a') << (5 * j);
            }
            codes[i] = code;
        }
        int[] dp = Enumerable.Repeat(1, n).ToArray();
        int[] prev = Enumerable.Repeat(-1, n).ToArray();
        int maxLen = 1, maxIdx = 0;
        Dictionary<long, List<int>>[][] patterns = new Dictionary<long, List<int>>[11][];
        for (int i = 0; i < n; i++) {
            int L = words[i].Length, g = groups[i];
            if (patterns[L] == null) {
                patterns[L] = new Dictionary<long, List<int>>[L];
                for (int j = 0; j < L; j++)
                    patterns[L][j] = new Dictionary<long, List<int>>();
            }
            var buckets = patterns[L];
            long codeI = codes[i];
            int best = 1, bp = -1;
            for (int j = 0; j < L; j++) {
                long pat = codeI & ~(31L << (5 * j));
                if (buckets[j].TryGetValue(pat, out var lst)) {
                    foreach (int k in lst) {
                        if (groups[k] != g && dp[k] + 1 > best) {
                            best = dp[k] + 1; bp = k;
                        }
                    }
                }
            }
            dp[i] = best; prev[i] = bp;
            if (best > maxLen) { maxLen = best; maxIdx = i; }
            for (int j = 0; j < L; j++) {
                long pat = codeI & ~(31L << (5 * j));
                if (!patterns[L][j].TryGetValue(pat, out var lst))
                    patterns[L][j][pat] = lst = new List<int>();
                lst.Add(i);
            }
        }
        var res = new List<string>();
        for (int cur = maxIdx; cur != -1; cur = prev[cur])
            res.Add(words[cur]);
        res.Reverse();
        return res;
    }
}