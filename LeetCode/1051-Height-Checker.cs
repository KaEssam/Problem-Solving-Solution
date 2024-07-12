public class Solution {
    public int HeightChecker(int[] heights) {
        int count = 0;
		
		var expected = new List<int>(heights);
		
		expected.Sort();
		
		
		
		for (int i = 0; i < heights.Length; i++)
		{
			if (heights[i] != expected[i] )
			
			{
				count++;
			}
		}
		return count;
    }
}