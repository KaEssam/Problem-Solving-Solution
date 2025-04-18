public class Solution {
    public string CountAndSay(int n) {
        if (n == 1) return \1\;
        string res = \1\;

        for (int i = 1; i < n; i++) {
            string temp = \\;
            int count = 1;

            for (int j = 1; j < res.Length; j++) {
                if (res[j] == res[j - 1]) {
                    count++; 
                } else {
                    temp += count.ToString() + res[j - 1];
                    count = 1;
                }
            }

            temp += count.ToString() + res[^1];
            res = temp;
        }

        return res;
    }
}