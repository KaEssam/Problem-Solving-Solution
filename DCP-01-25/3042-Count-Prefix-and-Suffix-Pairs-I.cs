public class Solution {

    private bool IsPrefixAndSuffix(string str1, string str2) {
        int n1 = str1.Length, n2 = str2.Length;
        if (n1 > n2) return false;

        return str2.Substring(0, n1) == str1 && str2.Substring(n2 - n1) == str1;
    }

    public int CountPrefixSuffixPairs(string[] words) {
        int count = 0;
        int n = words.Length;

        for (int i = 0; i < n; ++i) {
            for (int j = i + 1; j < n; ++j) {
                if (IsPrefixAndSuffix(words[i], words[j])) {
                    count++;
                }
            }
        }
        return count;
    }
}