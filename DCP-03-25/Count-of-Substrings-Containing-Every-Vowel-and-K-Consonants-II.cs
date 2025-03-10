public class Solution {
    public long CountOfSubstrings(string word, int k) {
        int len = word.Length;
        long res = 0;
        if(len < 5+k)
            return res;

        HashSet<char> vowSet = new HashSet<char>("aeiou");
        Dictionary<char, int> vowels = new();

        int consCnt = 0;
        int[] nextCons = new int[len];
        int conId = len;
        for(int i = len-1; i >= 0; i--)
        {
            nextCons[i] = conId;
            if(!vowSet.Contains(word[i]))
                conId = i;
        }

       // slide window:
       int left = 0, right = 0;
       while(right < len)
       {
            // expand window:
            char r = word[right];
            if(vowSet.Contains(r))
            {
                vowels.TryAdd(r, 0);
                vowels[r]++;
            }
            else
                consCnt++;

            // shrink:
            while(left <= right && consCnt >k)
            {
                char l = word[left++];
                if(vowSet.Contains(l))
                {
                    if(vowels.ContainsKey(l))
                    {
                        if(--vowels[l] == 0)
                            vowels.Remove(l);
                    }
                }
                else
                    consCnt--;
            }

            // Count valid substrings:
            while(left < right && vowels.Count == 5 && consCnt == k)
            {
                res += (nextCons[right] - right);
                if(vowSet.Contains(word[left]))
                {
                    if(--vowels[word[left]] == 0)
                        vowels.Remove(word[left]);
                }
                else
                    consCnt--;

                left++;
            }

            right++;
       }

        return res;
    }
}