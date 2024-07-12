public class Solution {
    public int MaximumWealth(int[][] accounts) {
        
        int[] result = new int[accounts.Length];
        for (int i =0; i <accounts.Length; i++)
        {
            int customer = 0;

            for (int j = 0; j < accounts[i].Length; j++)
            {
                customer = customer + accounts[i][j];
            }
            result[i] = customer;
        }
        int largest = result.Max();
        return largest;
    }
}
