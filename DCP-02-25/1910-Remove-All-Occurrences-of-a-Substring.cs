public class Solution {
    public string RemoveOccurrences(string s, string part) {
        int index;
        while ((index = s.IndexOf(part)) != -1) {
            s = s.Remove(index, part.Length);
        }
        
        return s;
    }
}