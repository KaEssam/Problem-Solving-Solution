public class Solution {
    public int MaxScore(string s) {
        int n = s.Length;

        int[] prefixZero = new int[n];
        int[] suffixOne = new int[n];

        prefixZero[0] = s[0] == '0' ? 1 : 0; 
        for (int i = 1; i < n; i++) {        
            prefixZero[i] = prefixZero[i - 1] + (s[i] == '0' ? 1 : 0);
        }

        suffixOne[n - 1] = s[n - 1] == '1' ? 1 : 0; 
        for (int i = n - 2; i >= 0; i--) {          
            suffixOne[i] = suffixOne[i + 1] + (s[i] == '1' ? 1 : 0);
        }

        int maxScore = 0;
        for (int i = 1; i < n; i++) { 
            int score = prefixZero[i - 1] + suffixOne[i];
            maxScore = Math.Max(maxScore, score); 
        }

        return maxScore; 
    }
}