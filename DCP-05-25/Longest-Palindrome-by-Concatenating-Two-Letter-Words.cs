public class Solution {
    public int LongestPalindrome(string[] words) {
        Dictionary<string, int> freq = new();
        foreach(string s in words)
        {
            freq.TryAdd(s, 0);
            freq[s]++;
        }

        bool dupOdd = false;
        int res = 0;
        HashSet<string> visited = new();
        foreach(var kvp in freq)
        {
            string key = kvp.Key;
            if(visited.Contains(key))
                continue;

            int f = kvp.Value;
            visited.Add(key);
            if(key[0] == key[1])
            {
                if(f%2 == 1)
                {
                    dupOdd = true;
                    f--;
                }

                res += 2*f;
            }
            else
            {
                string revS = new string([key[1], key[0]]);
                if(!visited.Contains(revS) && freq.ContainsKey(revS))
                {
                    f = Math.Min(f, freq[revS]);
                    res += f*4;

                    visited.Add(revS);
                }
            }
        }

        if(dupOdd)
            res += 2;

        return res;
    }
}