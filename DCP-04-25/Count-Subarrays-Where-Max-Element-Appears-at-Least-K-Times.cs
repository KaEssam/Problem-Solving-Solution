public class Solution {
    public long CountSubarrays(int[] elements, int threshold) {
        long arrayLength = elements.Length;
        long maxElement = elements.Max();
        long leftIndex = 0, rightIndex = 0, maxElementCount = 0, subarrayCount = 0;

        while (rightIndex < arrayLength) {
            if (elements[rightIndex] == maxElement) {
                maxElementCount++;
            }
            if (maxElementCount >= threshold) {
                while (maxElementCount >= threshold) {
                    subarrayCount += arrayLength - rightIndex;
                    if (elements[leftIndex] == maxElement) {
                        maxElementCount--;
                    }
                    leftIndex++;
                }
            }
            rightIndex++;
        }
        return subarrayCount;
    }
}