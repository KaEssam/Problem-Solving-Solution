public class Solution {
    public int MinimizeXor(int num1, int num2) {
        int a = BitOperations.PopCount((uint)num1);
        int b = BitOperations.PopCount((uint)num2);
        int res = num1;
        for (int i = 0; i < 32; i++) {
            if (a > b && ((1 << i) & num1) != 0) {
                res ^= 1 << i;
                a--;
            }
            if (a < b && ((1 << i) & num1) == 0) {
                res ^= 1 << i;
                a++;
            }
        }
        return res;
    }
}