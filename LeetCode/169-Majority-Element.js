/**
 * @param {number[]} nums
 * @return {number}
 */
var majorityElement = function(nums) {
    let res = 0;
    let majority = 0;

    for(let n of nums){
        if(majority == 0){
            res = n;
        }
        majority += n == res ? 1 : -1;
    }

    return res;
};