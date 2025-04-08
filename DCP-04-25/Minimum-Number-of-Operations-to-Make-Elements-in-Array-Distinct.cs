public class Solution {
    public int MinimumOperations(int[] nums) {
        int cont=0;
        var list=nums.ToList();        
        while(list.Count()>list.Distinct().Count()){
            list=list.Skip(3).ToList();
            cont++;
        }
        return cont;
    }
}