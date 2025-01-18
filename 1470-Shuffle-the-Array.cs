public class Solution {
    public int[] Shuffle(int[] nums, int n) {
        //idea: reformat array[x,y]

        //approch: 1- check is n able to divid 2. 2- 

        // int[] shuffledArray = new int[2*n];

        // int j = 0; //1

        // for(int i =0; i < n; i++){
        //     shuffledArray[j] = nums[i];
        //     shuffledArray[++j] = nums[i+n]; 
        //     j++;
        // }
        // return shuffledArray;

        int[] shuffledArray = new int[nums.Length];

        for(int i = 0; i < n; i++){
            shuffledArray[i*2] = nums[i];        //[x1,y1,x2,]
            shuffledArray[i*2+1]= nums[i+n];
        }
        return shuffledArray;
    }
}