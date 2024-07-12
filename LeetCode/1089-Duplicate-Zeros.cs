public class Solution {
    public void DuplicateZeros(int[] arr) {
        for (int i = 0; i < arr.Length - 1; i ++){
            if (arr[i] == 0){
                for (int j = arr.Length - 1; j > i; j --){
                    arr[j] = arr[j - 1];
                }
                i ++;
            }
        }
    }
}