public class Solution {
    public bool ValidMountainArray(int[] arr) {

    if (arr.Length < 3)
      return false;

    int i = 0;
    
    for (i = 1; i < arr.Length; i++)
      if (arr[i] <= arr[i - 1])
        break;
 
    if (i == arr.Length || i == 1)
      return false;
 
    for (; i < arr.Length; i++)
      if (arr[i] >= arr[i - 1])
        break;
    return i == arr.Length;
    }
}