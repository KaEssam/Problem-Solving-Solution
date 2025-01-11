public class Solution {
    public bool CanConstruct(string s, int k) {
        if (s.Length < k) return false;

        char[] chars = s.ToCharArray();
        Array.Sort(chars);
        int oddCount = 0;

        for (int i = 0; i < chars.Length; ) {
            char current = chars[i];
            int count = 0;
            while (i < chars.Length && chars[i] == current) {
                count++;
                i++;
            }
            if (count % 2 != 0) oddCount++;
        }

        return oddCount <= k;
    }
}