public class Solution 
{
    public long MaximumValueSum(int[] nums, int k, int[][] edges) 
    {
        long result = 0;

        foreach (long num in nums)
            result += num;
        
        var queue = new PriorityQueue<int, int>();
        
        foreach (var num in nums)
        {
            var xor = num ^ k;
            var diff = xor - num;
            
            queue.Enqueue(diff, -diff);
        }
        
        while (queue.Count >= 2)
        {
            var value = queue.Dequeue() + queue.Dequeue();
            
            if (value > 0)
                result += value;
        }
        
        return result;
    }
}