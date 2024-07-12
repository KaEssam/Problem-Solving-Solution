public class Solution {
    public char FindTheDifference(string s, string t) {
        var sCount = 0;
        var tCount = 0;
        for (var i = 0; i < t.Length; i++) {

            tCount += t[i];
            if(i < s.Length) sCount += s[i];
        }

        return (char)(tCount - sCount);
    }
}