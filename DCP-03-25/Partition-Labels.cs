public class Solution {
    public IList<int> PartitionLabels(string s) {
        Dictionary<char, int> lastOccurrence = new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++) {
            lastOccurrence[s[i]] = i;
        }

        List<int> result = new List<int>();
        int start = 0, end = 0;

        for (int i = 0; i < s.Length; i++) {
            end = Math.Max(end, lastOccurrence[s[i]]);
            if (i == end) {
                result.Add(end - start + 1);
                start = i + 1;
            }
        }

        return result;
    }
}