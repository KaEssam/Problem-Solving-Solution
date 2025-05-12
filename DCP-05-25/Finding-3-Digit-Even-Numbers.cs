public class Solution {
    public int[] FindEvenNumbers(int[] digits) {
        int[] count = new int[10];
        foreach (int d in digits) count[d]++;

        List<int> result = new List<int>();
        for (int i = 100; i <= 999; i += 2) {
            int h = i / 100;
            int t = (i % 100) / 10;
            int o = i % 10;
            count[h]--; count[t]--; count[o]--;
            if (count[h] >= 0 && count[t] >= 0 && count[o] >= 0)
                result.Add(i);
            count[h]++; count[t]++; count[o]++;
        }

        return result.ToArray();
    }
}