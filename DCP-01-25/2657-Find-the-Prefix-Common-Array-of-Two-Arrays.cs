public class Solution
{
    public int[] FindThePrefixCommonArray(int[] A, int[] B)
    {
        int[] freq = new int[A.Length + 1]; 
        int[] result = new int[A.Length]; 
        int counter = 0; 

        for (int i = 0; i < A.Length; i++)
        {
            freq[A[i]]++;
            freq[B[i]]++;

            if (freq[A[i]] == 2)
            {
                counter++;
            }

            if (freq[B[i]] == 2 && A[i] != B[i])
            {
                counter++;
            }

            result[i] = counter;
        }

        return result;
    }
}