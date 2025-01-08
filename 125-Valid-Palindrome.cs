public class Solution {
    public bool IsPalindrome(string s) {
        string newStr = new string(s.Where(char.IsLetterOrDigit)
                                  .Select(char.ToLower)
                                  .ToArray());
        return newStr.SequenceEqual(newStr.Reverse());
    }
}