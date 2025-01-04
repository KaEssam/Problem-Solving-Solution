public class Solution {
    public int CountPalindromicSubsequence(string s) {
        int[] R = new int[26];  
        int[] L = new int[26];  
        HashSet<int> S = new HashSet<int>();  
        int result = 0;

        foreach (char c in s) {
            R[c - 'a']++;
        }

        foreach (char c in s) {
            int t = c - 'a';
            R[t]--;  
            for (int j = 0; j < 26; j++) {
                if (L[j] > 0 && R[j] > 0) {
                    S.Add(26 * t + j);  
                }
            }

            L[t]++;  
        }

        return S.Count;
    }
}