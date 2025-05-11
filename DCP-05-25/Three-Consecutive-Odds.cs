public class Solution {
    public bool ThreeConsecutiveOdds(int[] arr) {
        var streak = 0;
        for(var i = 0; i < arr.Length; i++){
        if(arr[i] % 2 != 0){
            streak++;
            if(streak == 3){
                return true;
            }
        }else{
            streak = 0;
        }
    }
    return false;
    }
}