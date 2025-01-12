public class Solution {
    public bool CanBeValid(string s, string locked) {
        int n = s.Length;
        if(n % 2 == 1) return false;
        int close = 0, open = 0;
        for(int i = 0; i!=n; ++i){
            if(locked[i] == '1' && s[i] == ')') close++;
            if(locked[n-1-i] == '1' && s[n-1-i] == '(') open++;
            if(open > (i+1)/2 || close > (i+1)/2) return false;
        }
        return true;
    }
}