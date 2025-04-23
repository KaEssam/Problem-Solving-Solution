public class Solution {
    public int CountLargestGroup(int n) {
        Dictionary<int, int> freq = new();
        int max = 0;

        for(int i=1; i<=n; i++){
            int sum=0, x = i;

            while(x > 0){
                sum += x%10;
                x /= 10;
            }
            if(!freq.ContainsKey(sum)){
                freq[sum] = 0;
            }
            freq[sum]++;
            max = max > freq[sum] ? max : freq[sum];
        }

        return freq.Values.Count( x => x == max);

    }
}