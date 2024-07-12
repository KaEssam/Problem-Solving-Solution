public class Solution {
    public int[] ReplaceElements(int[] arr) {
        for (int i = 0; i < arr.Length; i++) 
        { 
            int max_value = -1; 
            for (int j = i + 1; j < arr.Length; j++) 
            { 
                max_value = Math.Max(max_value, arr[j]); 
            } 
            arr[i] = max_value; 
        }
        return arr;
    }
}