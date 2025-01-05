public class Solution {
    public string ShiftingLetters(string s, int[][] shifts) {
        int n = s.Length;
        int[] shiftCount = new int[n];
        
        foreach (var shift in shifts) {
            int start = shift[0];
            int end = shift[1];
            int direction = shift[2];

            for (int i = start; i <= end; i++) {
                shiftCount[i] += (direction == 1) ? 1 : -1;
            }
        }
        char[] result = s.ToCharArray();
        for (int i = 0; i < n; i++) {
            int shift = shiftCount[i] % 26; 
            if (shift < 0) shift += 26;    

            result[i] = (char)('a' + (result[i] - 'a' + shift) % 26);
        }

        return new string(result);
    }
}