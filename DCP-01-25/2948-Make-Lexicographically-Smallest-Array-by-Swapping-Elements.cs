public class Solution {
     public int[] LexicographicallySmallestArray(int[] nums, int limit)
 {
     var aux = GetAux(nums, limit);
     var rs = new int[nums.Length];
     for (int i = 0; i < aux.Count; i++)
     {
         for (int j = 0; j < aux[i][1].Count; j++)
         {
             rs[aux[i][1][j]] = aux[i][0][j];
         }
     }
     return rs;
 }
 private List<List<int>[]> GetAux(int[] nums, int limit)
 {
     var indexes = SortIndex(nums);
     var rs = new List<List<int>[]>();
     rs.Add(new List<int>[] { new List<int> { indexes[0].val }, new List<int> { indexes[0].index } });
     for (int i = 1; i < indexes.Count; i++)
     {
         var prevVal = rs[rs.Count - 1][0][rs[rs.Count - 1][0].Count - 1];
         if (indexes[i].val - prevVal <= limit)
         {
             rs[rs.Count - 1][0].Add(indexes[i].val);
             rs[rs.Count - 1][1].Add(indexes[i].index);
         }
         else
         {
             rs.Add(new List<int>[] { new List<int> { indexes[i].val }, new List<int> { indexes[i].index } });
         }
     }
     for (int i = 0; i < rs.Count; i++)
     {
         rs[i][1].Sort();
     }
     return rs;
 }
 private List<(int val, int index)> SortIndex(int[] nums)
 {
     var rs = new List<(int val, int index)>();
     for (int i = 0; i < nums.Length; i++)
     {
         rs.Add((nums[i], i));
     }
     rs = rs.OrderBy(p => p.val).ToList();
     return rs;
 }
}