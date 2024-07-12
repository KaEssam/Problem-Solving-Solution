public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int right = 0;
        int left=0;
        int maxLength=0;

        List<char> sub =new List<char>();

        while(right < s.Length){
            // check if char not in right side, add char untill u find repeated char
            if(!sub.Contains(s[right])){
                sub.Add(s[right]);
                right++;
                //count max char of not repeated char 
                maxLength= Math.Max(maxLength, right-left);
            }else{
                sub.Remove(s[left]);
                left++;
            }

        }
        return maxLength;
    }
}