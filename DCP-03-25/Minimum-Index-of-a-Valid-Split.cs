public class Solution {
       public int MinimumIndex(IList<int> nums)
    {
        var n = nums.Count;

        var mostFrequentNumber = FindMostFrequentNumber(nums);

        var totalCountOfMostFrequentNumber = 0;
        for (var i = 0; i < n; i++)
            if (nums[i] == mostFrequentNumber)
                totalCountOfMostFrequentNumber++;

        var leftDoubled = 0;
        var rightDoubled = totalCountOfMostFrequentNumber * 2;
        var leftLength = 0;
        var rightLength = n;
        for (var i = 0; i < n; i++)
        {
            leftLength++;
            rightLength--;
            if (nums[i] == mostFrequentNumber)
            {
                leftDoubled += 2;
                rightDoubled -= 2;
            }

            if (leftDoubled > leftLength && rightDoubled > rightLength)
                return i;
        }

        return -1;
    }

    private int FindMostFrequentNumber(IList<int> nums)
    {
        var res = 0;
        var count = 1;
        for (var i = 1; i < nums.Count; i++)
        {
            if (nums[i] == nums[res])
                count++;
            else
                count--;

            if (count == 0)
            {
                res = i;
                count = 1;
            }
        }

        return nums[res];
    }
}