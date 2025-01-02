public class Solution {

     private bool IsVowelString(string word)
    {
        string vowels = "aeiou";
        return vowels.Contains(word[0]) && vowels.Contains(word[word.Length - 1]);
    }

    public int[] VowelStrings(string[] words, int[][] queries) {
        int n = words.Length;
        int q = queries.Length;

        int[] vowelWords = new int[n];
        for (int i = 0; i < n; i++)
        {
            if (IsVowelString(words[i]))
            {
                vowelWords[i] = 1;
            }
            else
            {
                vowelWords[i] = 0;
            }
        }

        int[] prefixSum = new int[n + 1];
        for (int i = 0; i < n; i++)
        {
            prefixSum[i + 1] = prefixSum[i] + vowelWords[i];
        }

        int[] result = new int[q];
        for (int i = 0; i < q; i++)
        {
            int li = queries[i][0];
            int ri = queries[i][1];
            result[i] = prefixSum[ri + 1] - prefixSum[li];
        }

        return result;
    
    }
}