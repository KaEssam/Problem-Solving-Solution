/**
 * @param {number[]} nums
 * @return {number}
 */
var pivotIndex = function(nums) {
        let sum = 0;
        let leftsum = 0;
        let n = nums.length;
 
        for (let i = 0; i < n; i++){
            sum += nums[i];
        }
 
        for (let j = 0; j < n; j++) {
        
            if ( sum - leftsum - nums[j] == leftsum){
                return j;
            }
            leftsum += nums[j];
        }

        return -1;
};