public class Solution {
    public string GetHappyString(int n, int k) {
        int total = 3 * (int)Math.Pow(2, n - 1);
        if (k > total) return "";

        StringBuilder ans = new StringBuilder();
        char prev = '\0';

        for (int i = 0; i < n; i++) {
            int block_size = (int)Math.Pow(2, n - i - 1);
            int block_index = (k - 1) / block_size;

            if (prev == '\0') {
                ans.Append((char)('a' + block_index));
            } else {
                ans.Append(GetChar(prev, block_index));
            }

            prev = ans[ans.Length - 1];
            k -= block_index * block_size;
        }

        return ans.ToString();
    }

    private char GetChar(char prev, int blockIndex) {
        if (prev == 'a') {
            return blockIndex == 0 ? 'b' : 'c';
        } else if (prev == 'b') {
            return blockIndex == 0 ? 'a' : 'c';
        } else {
            return blockIndex == 0 ? 'a' : 'b';
        }
    }
}