public class Solution {
    public int DifferenceOfSums(int n, int m) {
        int num1 = 0, num2 = 0;
        while (n > 0) {
            if (n % m == 0)
                num2 += n;
            else
                num1 += n;
            n--;
        }
        return num1 - num2;
    }
}