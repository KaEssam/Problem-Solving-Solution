public class Solution {
    public bool CheckIfExist(int[] arr) {
        var hash = new HashSet<int>(arr.Length);

        foreach (var item in arr)
        {
            if (hash.Contains(item * 2) || (item % 2 == 0 && hash.Contains(item / 2)))
            {
                return true;
            }

            hash.Add(item);
        }

        return false;
    }
}