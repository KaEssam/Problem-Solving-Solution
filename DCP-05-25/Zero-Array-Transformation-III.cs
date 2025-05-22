public class Solution {
    public int MaxRemoval(int[] nums, int[][] queries) {
            queries = queries.OrderBy(q => q[0]).ThenByDescending(q => q[1]).ToArray();

			int len = nums.Length, res = 0, qLen = queries.Length;
			PriorityQueue<int, int> pq = new();

			int[] end = new int[len+1];
			int cur = 0, idx = 0;

			for (int i = 0; i < len; i++) 
			{
				cur += end[i];
				while (idx < qLen && queries[idx][0] <= i)
				{
					pq.Enqueue(-queries[idx][1], -queries[idx++][1]);
				}

				while (cur < nums[i])
				{
					if (pq.Count == 0 || (-pq.Peek()) < i)
						return -1;

					end[-pq.Dequeue() + 1]--;
					cur++;
				}
			}
			

			return pq.Count;
  
    }
}