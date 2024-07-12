/**
 * @param {number[]} nums
 * @return {number}
 */
var minDifference = function(nums) {
    
    // we check if the input array fewer 4 cos we cant make all nums equal wih 3 moves
    if(nums.length <= 4){
        return 0;
    };

    nums.sort((a,b) => a - b);

    let s = nums[nums.length - 1] - nums[0];

    for (let i =0; i <= 3; i++){
        s = Math.min(s, nums[nums.length - (3 - i) - 1] - nums[i]);
    }

    return s;
};