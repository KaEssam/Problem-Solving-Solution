public class Solution {
    public string GetSmallestString(string s) {

        char[] arr = s.ToCharArray();

        for (int i = 0; i < arr.Length - 1; i++) {
            if ((arr[i] - '0') % 2 == (arr[i + 1] - '0') % 2 && arr[i] > arr[i + 1]) {
                (arr[i], arr[i + 1]) = (arr[i + 1], arr[i]);
                break;
            }
        }

        return new string(arr);
    }
}
